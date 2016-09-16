using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Threading.Tasks;

namespace Jeopardy_Editor
{
    class LoadData
    {
        public int TotalCatagories { get { return totalCatagories; } }
        public int DeadSpace { get { return deadSpace; } }
        public string RomName { get { return romName; } }
        public int TotalSize { get { return totalSize; } }

        int deadSpace = 0;
        string romName = "";
        int totalCatagories = 0;
        int totalSize = 0;

        const int START_OF_TEXT = Globals.ROMFILE_TEXT_BEGIN;
        const int END_OF_TEXT = Globals.ROMFILE_TEXT_END;
        const int START_OF_POINTERTABLE = Globals.ROMFILE_POINTER_BEGIN;
        const int END_OF_POINTERTABLE = Globals.ROMFILE_POINTER_END;

        List<Catagory> Catagories;
        List<RomPointer> Pointers;

        public LoadData(ref List<Catagory> cat, ref List<RomPointer> pointers)
        {
            Catagories = cat;
            Pointers = pointers;
        }

        public bool FromXML(string newname = "jeopardy-save.xml")
        {
            // Return if file doesn't exist, or no rom file has been loaded in.
            if (!File.Exists(newname) || Catagories.Count < 1) return false;

            int i = 0;
            XmlReader xm = XmlReader.Create(newname);
            while (!xm.EOF) 
            {
                xm.ReadToFollowing("Catagory");

                // Get fullname; address; size
                xm.ReadToFollowing("name");
                string xname = xm.ReadInnerXml();
                if (xname == "") break;
                Catagories[i].setName(xname);


                // Move to Questions
                xm.ReadToFollowing("Questions");
                for (int x = 0; x < 5; x++) {
                    xm.ReadToFollowing("question");
                    Catagories[i].setQuestion(x, xm.ReadInnerXml());
                }

                // Move to Answers
                xm.ReadToFollowing("Answers");
                for (int x = 0; x < 5; x++)
                {
                    xm.ReadToFollowing("answer");
                    xm.ReadToFollowing("value");
                    string v = xm.ReadInnerXml();
                    xm.ReadToFollowing("type");
                    string t = xm.ReadInnerXml();
                    Catagories[i].setAnswer(x, v, Convert.ToInt32(t));

                }

                i++;

            }

            xm.Close();

            return true;
        }

        public bool FromRom(string newname = "jeopardy.smc")
        {
            FileStream fs = new FileStream(newname, FileMode.Open);

            // Get Rom Header Title and Check if loaded rom is Jeopardy!
            fs.Seek(Globals.ROMFILE_HEADER_TITLE_POS, SeekOrigin.Begin);
            byte[] romByteTitle = new byte[Globals.ROMFILE_HEADER_TITLE_SIZE];
            string romTitle = "";
            fs.Read(romByteTitle, 0, Globals.ROMFILE_HEADER_TITLE_SIZE);
            for (int i = 0; i < romByteTitle.Length; i++)
                romTitle += Convert.ToChar(romByteTitle[i]);

            romName = romTitle;

            if (!romTitle.Contains(Globals.ROMFILE_HEADER_TITLE_STRING))
                return false;

            fs.Seek(START_OF_TEXT, SeekOrigin.Begin);

            string[] rawdata = new string[11];
            int si = 0;
            int blankspace = 0;
            int blankspaceTemp = 0;
            int loc = START_OF_TEXT;
            for (int i = START_OF_TEXT; i < END_OF_TEXT + 1; i++)
            {
                char t = Convert.ToChar(fs.ReadByte());
                totalSize++;

                if (t != 0x00)
                {
                    if (t == 0x11)
                    {
                        blankspace++;
                        blankspaceTemp++;
                    }
                    else
                    {
                        rawdata[si] += t;
                    }
                }
                else
                {
                    si++;
                }

                // When finished with block; create catagory and start over
                if (si > 10)
                {
                    si = 0;
                    Catagory c = new Catagory(loc, rawdata);
                    Catagories.Add(c);
                    Array.Clear(rawdata, 0, rawdata.Length);
                    loc = i + 1 + blankspaceTemp;
                    blankspaceTemp = 0;
                    totalCatagories++;
                }
            }

            deadSpace = blankspace;

            if (Pointers == null) return true;

            // ========= SCAN THOUGH POINTER TABLE =========
            fs.Seek(START_OF_POINTERTABLE, SeekOrigin.Begin);

            int location = START_OF_POINTERTABLE;
            int id = 0;
            while (fs.Position < END_OF_POINTERTABLE) 
            {
                location = Convert.ToInt32(fs.Position);
                byte bank = Convert.ToByte(fs.ReadByte());
                byte addrUp = Convert.ToByte(fs.ReadByte());
                byte addrDn = Convert.ToByte(fs.ReadByte());
                byte end = Convert.ToByte(fs.ReadByte());
                RomPointer rp = new RomPointer(id, bank, addrUp, addrDn, end, location);
                Pointers.Add(rp);
                //Console.WriteLine(rp.To() + "  |  High: " + addrUp + "  Low: " + addrDn + "  Bank: " + bank);

                id++;
            }

            Console.WriteLine("Total Pointers: " + Pointers.Count);

            Console.WriteLine("Pointers matched to catagory: " + SetPointersToCatagories());

            fs.Close();

            return true;
        }

        public int SetPointersToCatagories()
        {
            // Return negative if either is null
            if (Pointers == null || Catagories == null) return -1;

            Console.WriteLine(Pointers[0].To() + "   " + Pointers[0].getPoint());

            int totalFound = 0;
            for (int p = 0; p < Pointers.Count; p++)
            {
                bool bFound = false;
                for (int c = 0; c < Catagories.Count; c++)
                {
                    int pp = Pointers[p].getPoint();
                    if (pp == Catagories[c].getAddress())
                    {
                        Catagories[c].pointer = Pointers[p];
                        
                        totalFound++;
                        Pointers[p].isPointed = true;
                        bFound = true;
                        break;
                    }
                }

                if (!bFound) Catagories[p].pointer = Pointers[p];
            }

            return totalFound;
        }

    }
}
