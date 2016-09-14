using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Threading.Tasks;

namespace Jeopardy_Editor
{
    class SaveData
    {
        List<Catagory> Catagories;

        public SaveData(ref List<Catagory> cats)
        {
            Catagories = cats;
        }

        public bool ToXML(string newname = "jeopardy-save.xml")
        {
            XmlWriterSettings xmSettings = new XmlWriterSettings();
            xmSettings.Indent = true;
            xmSettings.IndentChars = "\t";
            XmlWriter xm = XmlWriter.Create(newname, xmSettings);

            xm.WriteStartElement("Catagories");
            
            for (int i = 0; i < Catagories.Count; i++)
            {
                xm.WriteStartElement("Catagory");

                // Write Name:
                xm.WriteElementString("name", Catagories[i].getName());
                xm.WriteElementString("fullname", Catagories[i].getFullName(true));
                xm.WriteElementString("address", Convert.ToString(Catagories[i].getAddress()));
                xm.WriteElementString("size", Convert.ToString(Catagories[i].getSize()));

                // Write Questions:
                xm.WriteStartElement("Questions");
                for (int x = 0; x < 5; x++)
                {
                    xm.WriteElementString("question", Catagories[i].getQuestion(x, true));
                }
                xm.WriteEndElement();

                // Write Answers:
                xm.WriteStartElement("Answers");
                for (int x = 0; x < 5; x++)
                {
                    xm.WriteStartElement("answer");
                    xm.WriteElementString("value", Catagories[i].getAnswer(x));
                    xm.WriteElementString("type", Convert.ToString(Catagories[i].getAnswerType(x)));
                    xm.WriteEndElement();
                }
                xm.WriteEndElement();

                xm.WriteEndElement();
            }

            xm.WriteEndElement();
            xm.Flush();

            xm.Close();

            return true;
        }

        public bool ToRom(string newname = "jeopardy.smc")
        {
            // Check it exists first
            if (!File.Exists(newname)) return false;

            // Open rom file
            FileStream fs = new FileStream(newname, FileMode.Open);

            for (int c = 0; c < Catagories.Count; c++)
            {
                fs.Seek(Catagories[c].getAddress(), SeekOrigin.Begin);

                // GET NAME AND FORMAT FOR ROM
                string sName = Catagories[c].getFullName();
                byte[] name = convertToByte(sName, true);

                // Write to file
                fs.Write(name, 0, name.Length);

                // GET QUESTIONS AND ANSWERS AND FORMAT FOR ROM
                for (int q = 0; q < 5; q++)
                {
                    string sQuestion = Catagories[c].getQuestion(q);
                    string sAnswer = Catagories[c].getAnswer(q);
                    string sType = Catagories[c].getAnswerType(q, true);

                    byte[] question = convertToByte(sQuestion, true);
                    byte[] answer = convertToByte(sAnswer, true);
                    byte[] type = convertToByte(sType, false);

                    // Write to file
                    fs.Write(question, 0, question.Length);
                    fs.Write(type, 0, type.Length);
                    fs.Write(answer, 0, answer.Length);
                }
                
            }

            // ==== WRITE NEW POINTER TABLE ====
            fs.Seek(Globals.ROMFILE_POINTER_BEGIN, SeekOrigin.Begin);
            for (int i = 0; i < Catagories.Count; i++)
            {
                fs.WriteByte(Catagories[i].pointer.getBankAddress());
                fs.WriteByte(Catagories[i].pointer.getAddressHigh());
                fs.WriteByte(Catagories[i].pointer.getAddressLow());
                fs.Seek(fs.Position + 1, SeekOrigin.Begin);
                //fs.WriteByte(Catagories[i].pointer.getExtraByte());
            }


            fs.Close();

            return true;
        }


        /// <summary>
        /// Converts a string to a byte[] array.
        /// </summary>
        /// <param name="str">String to convert to byte[]</param>
        /// <param name="addnullbyte">Will add a null (0x00) byte to the end</param>
        private byte[] convertToByte(string str, bool addnullbyte = false)
        {
            int addN = 0;
            if (addnullbyte) addN = 1;

            byte[] b = new byte[str.Length + addN];
            for (int i = 0; i < str.Length; i++)
            {
                b[i] = Convert.ToByte(str[i]);
            }

            //if (addnullbyte) b[str.Length + addN] = 0x00;

            return b;
        }

    }

}
