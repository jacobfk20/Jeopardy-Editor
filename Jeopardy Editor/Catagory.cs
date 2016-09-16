using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeopardy_Editor
{
    class Catagory
    {
        public RomPointer pointer;               // This catagory's pointer.  
        long Address = 0x00FFFF;                 // The starting offset of this block
        string Name = "blank";                   // The name of this catagory
        string realName = "";                    // The full name of this catagory.
        int Size = 0;                            // The size of this block in char bytes.
        public bool bPointerAligned = false;     // If the pointer address aligns with this catagories address.

        struct Element
        {
            public string question;
            public string answer;
            public int type;
            public string rawtype;
        };

        Element[] elements = new Element[5];

        public Catagory(long address, string[] rawdata)
        {
            Address = address;

            if (rawdata[0] == null) return;

            // Get name length; add to total size (make up for missing null)
            Size += rawdata[0].Length + 1;

            // Grab clean name from raw data.
            Name = rawdata[0].Substring(rawdata[0].IndexOf("\\") + 1);

            // Keep full name (for saving / reloading to rom)
            realName = rawdata[0];

            // Loop through the catagory question/answer block and grab all data.
            int b = 1;
            for (int i = 0; i < 5; i++)
            {
                elements[i].question = rawdata[b];
                Size += elements[i].question.Length + 1;
                b++;
                elements[i].answer = rawdata[b];
                Size += elements[i].answer.Length + 1;
                b++;

                // Get answer type and rip it from answer
                string aT = elements[i].answer.Substring(0, 2);
                elements[i].rawtype = aT;
                elements[i].answer = elements[i].answer.Substring(2);
                if (!int.TryParse(aT, out elements[i].type))
                {
                    Console.WriteLine("Could not parse string to int! In Catagory: " + Name + "; Element " + i);
                }
            }
        }

        /// <summary>
        /// Checks if the catagorie's Pointer is actually pointing to it.
        /// </summary>
        /// <returns>false if Pointer is not pointing to it or it contains no pointer</returns>
        public bool checkPointerAligned()
        {
            if (pointer == null) return false;
            if (pointer.getPoint() == getAddress()) return true;
            return false;
        }

        /// <summary>
        /// Sets the answer and answer type based on index.  type will get raw string created as well.
        /// </summary>
        public void setAnswer(int index, string value, int type)
        {
            elements[index].answer = value;
            elements[index].type = type;

            if (type > 9) elements[index].rawtype = Convert.ToString(type);
            else elements[index].rawtype = "0" + Convert.ToString(type);

            updateSize();
        }

        /// <summary>
        /// Sets the question value for given index.
        /// </summary>
        public void setQuestion(int index, string value)
        {

            while (value.Contains("\r\n"))
            {
                value = value.Replace("\r\n", "\r");
                //value = value.Replace(value.IndexOf("\r"), value.IndexOf("\r")));
            }

            elements[index].question = value;

            updateSize();
        }

        /// <summary>
        /// Set the name of the catagory.
        /// </summary>
        /// <param name="displayname">What is displayed on the TV screen within game.</param>
        public void setName(string name, string displayname = "")
        {
            if (displayname == "") displayname = name;
            realName = displayname + "\\" + name;

            // Remove hard return and caridge return and replace with just /r
            while (realName.Contains("\r\n"))
                realName = realName.Replace("\r\n", "\r");

            Name = name;
        }

        /// <summary>
        /// Changes the address (location offset in rom file) of this cataogry
        /// </summary>
        public void setAddress(int address)
        {
            Address = address;
        }
        
        public string getName()
        {
            return Name;
        }

        public string getDisplayName()
        {
            string dname = realName;

            // Add hard returns to make readable
            dname = addHardReturn(dname);

            int divide = dname.IndexOf("\\");
            if (divide < 1) return dname;
            return dname.Substring(0, divide);
        }

        public string getFullName(bool saveFormat = false)
        {
            if (!saveFormat) return realName;
            return toSaveFormat(realName);
        }

        public string getQuestion(int index, bool saveFormat = false)
        {
            if (!saveFormat) return elements[index].question;
            return toSaveFormat(elements[index].question);
        }

        public string getReadableQuestion(int index)
        {
            string s = elements[index].question;
            string ns = "";
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] == 0x0D)
                {
                    ns += "\r\n";
                    //ns += "-";
                }
                else
                {
                    ns += s[i];
                }
            }

            return ns;
        }

        public string getAnswer(int index)
        {
            return elements[index].answer;
        }

        public int getAnswerType(int index)
        {
            return elements[index].type;
        }

        public string getAnswerType(int index, bool raw)
        {
            return elements[index].rawtype;
        }

        public int getSize()
        {
            return Size;
        }

        public long getAddress()
        {
            return Address;
        }

        public string getRawData()
        {
            string raw = realName;
            for(int i = 0; i < elements.Length; i++)
            {
                raw += elements[i].question;
                raw += elements[i].rawtype;
                raw += elements[i].answer;
            }

            return raw;
        }


        private string toSaveFormat(string str)
        {
            string ns = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 0x0D) ns += "|";
                else ns += str[i];
            }

            return ns;
        }

        private void updateSize()
        {
            Size = 0;
            Size += getFullName().Length + 1;  // With null
            for (int i = 0; i < 5; i++)
            {
                Size += elements[i].answer.Length;
                Size += elements[i].question.Length;
                Size += 2; // For answer type
                Size += 2; // for null chars between answer/question
            }
        }

        private string addHardReturn(string str)
        {
            string newString = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 0x0D)
                    newString += "\r\n";
                else
                    newString += str[i];
            }

            return newString;
        }
    }
}
