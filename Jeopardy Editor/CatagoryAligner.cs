using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeopardy_Editor
{
    class CatagoryAligner
    {
        int TextStart = Globals.ROMFILE_TEXT_BEGIN;

        public int RebuildStructure(ref List<Catagory> catagories)
        {
            int memorySize = catagories[0].getSize();    // Keeps track of how much all the catagories are taking in space

            for (int i = 1; i < catagories.Count; i++)
            {
                int newAddress = Convert.ToInt32(catagories[i - 1].getAddress());
                newAddress += catagories[i - 1].getSize();

                // Skip the catagory if it has no pointer.
                if (catagories[i].pointer == null) continue;

                // Check to make sure this address will not go outside of its bank (32k)
                int ptr = catagories[i].pointer.getAddress();
                int bank = catagories[i].pointer.getBankAddress();
                if (bank * 32768 + TextStart < ptr)
                {
                    Console.WriteLine("Catagory outside of range of bank! --" + catagories[i].getName());

                }

                catagories[i].setAddress(newAddress);
                catagories[i].pointer.setAddress(newAddress);

                memorySize += catagories[i].getSize();
            }

            return (memorySize + Globals.ROMFILE_TEXT_BEGIN) - Globals.ROMFILE_TEXT_END;
        }

    }
}
