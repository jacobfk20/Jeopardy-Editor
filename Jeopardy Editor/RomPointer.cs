using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeopardy_Editor
{
    public class RomPointer
    {
        public bool isPointed = false;              // Set if this pointer is known to be pointing to something

        int Location = 0;
        byte[] RawData = new Byte[4];
        byte AddressHigh = 0x00;
        byte AddressLow = 0x00;
        byte MemoryBank = 0x00;
        byte ExtraByte = 0x00;
        int ID = 0;
        
        public RomPointer(int id, byte bank, byte addrHigh, byte addrLow, byte extra, int location)
        {
            setAddress(bank, addrLow, addrHigh, extra);

            MemoryBank = bank;
            Location = location;

            ID = id;
        }

        public int getID()
        {
            return ID;
        }

        public byte getBankAddress()
        {
            return MemoryBank;
        }

        public byte getAddressHigh()
        {
            return AddressHigh;
        }

        public byte getAddressLow()
        {
            return AddressLow;
        }

        public byte getExtraByte()
        {
            return ExtraByte;
        }

        public int getBankAddressAsInt()
        {
            return Convert.ToInt32(MemoryBank);
        }

        public string getRawDataString(string sep = "-")
        {
            string data = MemoryBank + sep + AddressHigh + sep + AddressLow + sep + ExtraByte;
            return data;
        }

        /// <summary>
        /// Gets the pointer's pointing address that is formated for reading a ROM file.
        /// </summary>
        public int getPoint()
        {
            byte[] raw = { 0, 0, AddressHigh, AddressLow };
            Array.Reverse(raw);
            int address = BitConverter.ToInt32(raw, 0);
            address += 163840; // - 2048;
            address += (getBankAddressAsInt()) * 32768;
            return address;
        }

        /// <summary>
        /// Gets the Address of which this pointer points to.
        /// </summary>
        /// <param name="bClean">Will return formated in a way that is naviagational in a rom file</param>
        /// <returns>Integer of address</returns>
        public int To(bool bClean = false)
        {
            byte bank = MemoryBank;
            byte high = AddressHigh;
            byte low = AddressLow;

            byte[] raw = {0, bank, high, low };

            if (bClean)
                FormatForJed(ref bank, ref high);

            Array.Reverse(raw);
            int point = BitConverter.ToInt32(raw, 0);
            return point;
        }

        public int getAddress()
        {
            return Location;
        }

        /// <summary>
        /// Returns the pointer's data as byte {Bank, High, Low, Extra}
        /// </summary>
        public byte[] getData()
        {
            byte[] rawdata = { MemoryBank, AddressHigh, AddressLow, ExtraByte };
            return rawdata;
        }

        /// <summary>
        /// Gives the High and Low bytes of the Address relative to the SNES.
        /// </summary>
        public string getRawAddressString()
        {
            return AddressHigh.ToString().ToUpper() + " " + AddressLow.ToString().ToUpper();
        }

        /// <summary>
        /// Sets the what address this pointer points to by int.  
        /// </summary>
        /// <param name="address">New address.  This will be treated as dirty and converted for the SNES to understand.</param>
        public void setAddress(int address, byte extra = 0x02)
        {
            // Rom formating:
            address -= 32768 * MemoryBank;      // Keeps Within this pointer's memorybank. (32,768 bytes)
            address -= 32768;                   // Puts origin at 0.  What is left over is SNES friendly.

            // Convert address to byte array { 0 , Bank, High, Low }
            byte[] addr = BitConverter.GetBytes(address);
            

            setAddress(MemoryBank, addr[0], addr[1], extra);
        }

        /// <summary>
        /// Sets the address this pointer points to.  Be sure to FormatForRom!!
        /// </summary>
        /// <param name="bank">Which bank to set.  (Note: changing banks is not really allowed)</param>
        /// <param name="low">Low Byte</param>
        /// <param name="high">High Byte</param>
        public void setAddress(byte bank, byte low, byte high, byte extra = 0x02)
        {
            MemoryBank = bank;
            AddressLow = low;
            AddressHigh = high;
            ExtraByte = extra;
        }

        public void FormatForJed(ref byte bank, ref byte high) 
        {
            bank += 1;
            high += 8;
        }

        public void FormatForRom(ref byte bank, ref byte high)
        {
            bank -= 1;
            high -= 80;
        }
    }
}
