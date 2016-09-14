using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeopardy_Editor
{
    class CatagoryAligner
    {
        public int RebuildStructure(ref List<Catagory> catagories)
        {
            int memorySize = catagories[0].getSize();    // Keeps track of how much all the catagories are taking in space

            for (int i = 1; i < catagories.Count; i++)
            {
                int newAddress = Convert.ToInt32(catagories[i - 1].getAddress());
                newAddress += catagories[i - 1].getSize();

                catagories[i].setAddress(newAddress);

                catagories[i].pointer.setAddress(newAddress);
                Console.WriteLine(newAddress);

                memorySize += catagories[i].getSize();
            }

            return (memorySize + Globals.ROMFILE_TEXT_BEGIN) - Globals.ROMFILE_TEXT_END;
        }

    }
}
