﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Jeopardy_Editor
{
    public partial class Form1 : Form
    {
        const int START_OF_TEXT = Globals.ROMFILE_TEXT_BEGIN;
        const int END_OF_TEXT = Globals.ROMFILE_TEXT_END;
        string RomName = "";

        int SelectedCatagory = 0;

        List<Catagory> Catagories = new List<Catagory>();
        List<RomPointer> Pointers = new List<RomPointer>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = Globals.SOFTWARE_TITLE + " [" + Globals.SOFTWARE_VERSION_STRING + "]";
        }

        private void lstCatagories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Catagories.Count < 1) return;

            int index = SelectedCatagory;

            // Save changes before the switch
            if (txtQ1.TextLength > 0) Catagories[index].setQuestion(0, txtQ1.Text);
            if (txtQ2.TextLength > 0) Catagories[index].setQuestion(1, txtQ2.Text);
            if (txtQ3.TextLength > 0) Catagories[index].setQuestion(2, txtQ3.Text);
            if (txtQ4.TextLength > 0) Catagories[index].setQuestion(3, txtQ4.Text);
            if (txtQ5.TextLength > 0) Catagories[index].setQuestion(4, txtQ5.Text);
            if (txtA1.TextLength > 0) Catagories[index].setAnswer(0, txtA1.Text, 4); // TODO: ADD TYPE WHEN THAT IS DONE
            if (txtA2.TextLength > 0) Catagories[index].setAnswer(1, txtA2.Text, 4);
            if (txtA3.TextLength > 0) Catagories[index].setAnswer(2, txtA3.Text, 4);
            if (txtA4.TextLength > 0) Catagories[index].setAnswer(3, txtA4.Text, 4);
            if (txtA5.TextLength > 0) Catagories[index].setAnswer(4, txtA5.Text, 4);

            int currentIndex = lstCatagories.SelectedIndex;

            txtQ1.Text = Catagories[lstCatagories.SelectedIndex].getReadableQuestion(0);
            txtQ2.Text = Catagories[lstCatagories.SelectedIndex].getReadableQuestion(1);
            txtQ3.Text = Catagories[lstCatagories.SelectedIndex].getReadableQuestion(2);
            txtQ4.Text = Catagories[lstCatagories.SelectedIndex].getReadableQuestion(3);
            txtQ5.Text = Catagories[lstCatagories.SelectedIndex].getReadableQuestion(4);

            txtA1.Text = Catagories[lstCatagories.SelectedIndex].getAnswer(0);
            txtA2.Text = Catagories[lstCatagories.SelectedIndex].getAnswer(1);
            txtA3.Text = Catagories[lstCatagories.SelectedIndex].getAnswer(2);
            txtA4.Text = Catagories[lstCatagories.SelectedIndex].getAnswer(3);
            txtA5.Text = Catagories[lstCatagories.SelectedIndex].getAnswer(4);

            lblCatAddress.Text = Convert.ToString(Catagories[lstCatagories.SelectedIndex].getAddress());
            lblCatSize.Text = Convert.ToString(Catagories[lstCatagories.SelectedIndex].getSize()) + " bytes";
            if (Catagories[currentIndex].pointer != null)
            {
                lblPointer.Text = Convert.ToString(Catagories[currentIndex].pointer.getPoint());
                lblPointerAddress.Text = Convert.ToString(Catagories[currentIndex].pointer.getAddress());
                string pAddress = Convert.ToString(Catagories[currentIndex].pointer.To());
                lblSnesAddress.Text = Convert.ToString(Catagories[currentIndex].pointer.getRawAddressString());
                lblPointerBank.Text = Convert.ToString(Catagories[currentIndex].pointer.getBankAddressAsInt());
                if (Catagories[currentIndex].checkPointerAligned() == false) {
                    gbxPointerInfo.Text = "Pointer Info [Pointer Not Aligned!]";
                    gbxPointerInfo.ForeColor = Color.Red;
                } else {
                    gbxPointerInfo.Text = "Pointer Info";
                    gbxPointerInfo.ForeColor = Color.Black;
                }
                gbxPointerInfo.Enabled = true;
            }
            else
            {
                lblPointer.Text = "No Pointer!";
                lblPointerAddress.Text = "0";
                lblPointerBank.Text = "0";
                gbxPointerInfo.Enabled = false;
            }

            SelectedCatagory = lstCatagories.SelectedIndex;

            gbxQA.Enabled = true;
        }

        private void menuSaveToXml_Click(object sender, EventArgs e)
        {
            SaveData save = new SaveData(ref Catagories);
            save.ToXML();
        }

        private void menuSaveToRom_Click(object sender, EventArgs e)
        {
            SaveData save = new SaveData(ref Catagories);
            save.ToRom();
        }

        private void menuLoadXml_Click(object sender, EventArgs e)
        {
            LoadData load = new LoadData(ref Catagories, ref Pointers);
            if (load.FromXML()) reloadCatagoryList();
        }

        private void menuOpenRom_Click(object sender, EventArgs e)
        {
            destroyAllRomData();
            openRom.AddExtension = true;
            openRom.Title = "Open Jeopardy! SNES Rom file";
            openRom.ShowDialog();
            string romfile = openRom.FileName;
            
            if (romfile != "")
            {
                if (!romfile.Contains(".smc"))
                {
                    MessageBox.Show("This does not appear to be a SNES ROM.  (Lacks .smc)", "Load ROM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Catagories.Clear();
                LoadData load = new LoadData(ref Catagories, ref Pointers);
                if (load.FromRom(romfile)) reloadCatagoryList();
                else {
                    if (load.RomName != Globals.ROMFILE_HEADER_TITLE_STRING)
                        MessageBox.Show("Rom Header title mismatch.  Got: " + load.RomName + " Instead of: " + Globals.ROMFILE_HEADER_TITLE_STRING,
                            "Open Rom", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                RomName = load.RomName;

                lblDeadSpace.Text = Convert.ToString(load.DeadSpace);

                onRomLoad();
            }
        }

        private void reloadCatagoryList()
        {
            lstCatagories.Items.Clear();

            for (int i = 0; i < Catagories.Count; i++)
            {
                lstCatagories.Items.Add(Catagories[i].getName());
            }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<RomPointer> ptrs = new List<RomPointer>();
            for (int i = 0; i < Catagories.Count; i++)
                ptrs.Add(Catagories[i].pointer);

            PointerView pv = new PointerView(ptrs);
            pv.Show();
        }

        private void menuCloseRom_Click(object sender, EventArgs e)
        {
            destroyAllRomData();
            onRomClose();
        }

        private void destroyAllRomData()
        {
            Pointers.Clear();
            Catagories.Clear();
            lstCatagories.Items.Clear();
        }

        private void rebuildStructureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatagoryAligner c = new CatagoryAligner();
            int size = c.RebuildStructure(ref Catagories);
            if (size > 0) {
                lblDeadSpace.Text = size * -1 + " bytes  [Exceeding Heap]";
                lblDeadSpace.ForeColor = Color.Red;
            } else {
                lblDeadSpace.Text = size * - 1 + " bytes";
                lblDeadSpace.ForeColor = Color.Black;
            }
        }

        private void onRomLoad()
        {
            menuCloseRom.Enabled = true;
            menuSaveToRom.Enabled = true;
            menuSaveToXml.Enabled = true;
            menuLoadXml.Enabled = true;
            saveToolStripMenuItem.Enabled = true;
            viewToolStripMenuItem.Enabled = true;
            rebuildStructureToolStripMenuItem.Enabled = true;
            lblRomName.Text = RomName;
        }

        private void onRomClose()
        {
            menuCloseRom.Enabled = false;
            menuSaveToRom.Enabled = false;
            menuSaveToXml.Enabled = false;
            menuLoadXml.Enabled = false;
            saveToolStripMenuItem.Enabled = false;
            viewToolStripMenuItem.Enabled = false;
            rebuildStructureToolStripMenuItem.Enabled = false;
            lblRomName.Text = "No Rom Loaded";
            gbxQA.Enabled = false;
            txtQ1.Clear();
            txtQ2.Clear();
            txtQ3.Clear();
            txtQ4.Clear();
            txtQ5.Clear();
            txtA1.Clear();
            txtA2.Clear();
            txtA3.Clear();
            txtA4.Clear();
            txtA5.Clear();
        }

    }
}
