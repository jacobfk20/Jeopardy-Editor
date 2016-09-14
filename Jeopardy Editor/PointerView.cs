using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeopardy_Editor
{
    public partial class PointerView : Form
    {
        public List<RomPointer> Pointers;

        public PointerView(List<RomPointer> pointer)
        {
            Pointers = pointer;
            InitializeComponent();
        }

        private void PointerView_Load(object sender, EventArgs e)
        {
            if (Pointers.Count < 1) this.Close();

            for (int i = 0; i < Pointers.Count; i++)
            {
                if (Pointers[i].isPointed) lstPointers.Items.Add(Convert.ToString(Pointers[i].getPoint()) + " 0x" + Pointers[i].getRawDataString() + "    [p]");
                else lstPointers.Items.Add(Convert.ToString(Pointers[i].getPoint()) + " 0x" + Pointers[i].getRawDataString());
            }
        }

        private void lstPointers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstPointers.SelectedIndex;

            lblBank.Text = Convert.ToString(Pointers[index].getBankAddressAsInt());
            lblID.Text = Convert.ToString(Pointers[index].getID());

            byte[] data = Pointers[index].getData();
            string rawInfo = data[3] + " " + data[2] + " " + data[1] + " " + data[0];
            data = Pointers[index].getData();
            string cleanInfo = data[3] + " " + data[2] + " " + data[1] + " " + data[0];

            lblRawData.Text = rawInfo;
            lblCleanData.Text = cleanInfo;
        }
    }
}
