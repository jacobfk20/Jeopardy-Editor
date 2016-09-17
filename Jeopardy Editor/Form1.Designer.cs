namespace Jeopardy_Editor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstCatagories = new System.Windows.Forms.ListBox();
            this.gbxQA = new System.Windows.Forms.GroupBox();
            this.txtCatDisplayName = new System.Windows.Forms.TextBox();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.gbxPointerInfo = new System.Windows.Forms.GroupBox();
            this.lblSnesAddress = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblPointerBank = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblPointerAddress = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblPointer = new System.Windows.Forms.Label();
            this.lblCatSize = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblCatAddress = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtA5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQ5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtA4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQ4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtA3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQ3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtA2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQ2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtA1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQ1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDeadSpace = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotalCat = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblSizeChar = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpenRom = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCloseRom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveToXml = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveToRom = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLoadXml = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.rebuildStructureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRom = new System.Windows.Forms.OpenFileDialog();
            this.lblRomName = new System.Windows.Forms.Label();
            this.lblInvalidPointers = new System.Windows.Forms.Label();
            this.gbxQA.SuspendLayout();
            this.gbxPointerInfo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCatagories
            // 
            this.lstCatagories.FormattingEnabled = true;
            this.lstCatagories.Items.AddRange(new object[] {
            "Open a Jeopardy! rom!"});
            this.lstCatagories.Location = new System.Drawing.Point(12, 35);
            this.lstCatagories.Name = "lstCatagories";
            this.lstCatagories.Size = new System.Drawing.Size(223, 459);
            this.lstCatagories.TabIndex = 0;
            this.lstCatagories.SelectedIndexChanged += new System.EventHandler(this.lstCatagories_SelectedIndexChanged);
            // 
            // gbxQA
            // 
            this.gbxQA.Controls.Add(this.txtCatDisplayName);
            this.gbxQA.Controls.Add(this.txtCatName);
            this.gbxQA.Controls.Add(this.label21);
            this.gbxQA.Controls.Add(this.label20);
            this.gbxQA.Controls.Add(this.gbxPointerInfo);
            this.gbxQA.Controls.Add(this.lblCatSize);
            this.gbxQA.Controls.Add(this.label15);
            this.gbxQA.Controls.Add(this.lblCatAddress);
            this.gbxQA.Controls.Add(this.label14);
            this.gbxQA.Controls.Add(this.txtA5);
            this.gbxQA.Controls.Add(this.label9);
            this.gbxQA.Controls.Add(this.txtQ5);
            this.gbxQA.Controls.Add(this.label10);
            this.gbxQA.Controls.Add(this.txtA4);
            this.gbxQA.Controls.Add(this.label7);
            this.gbxQA.Controls.Add(this.txtQ4);
            this.gbxQA.Controls.Add(this.label8);
            this.gbxQA.Controls.Add(this.txtA3);
            this.gbxQA.Controls.Add(this.label5);
            this.gbxQA.Controls.Add(this.txtQ3);
            this.gbxQA.Controls.Add(this.label6);
            this.gbxQA.Controls.Add(this.txtA2);
            this.gbxQA.Controls.Add(this.label3);
            this.gbxQA.Controls.Add(this.txtQ2);
            this.gbxQA.Controls.Add(this.label4);
            this.gbxQA.Controls.Add(this.txtA1);
            this.gbxQA.Controls.Add(this.label2);
            this.gbxQA.Controls.Add(this.txtQ1);
            this.gbxQA.Controls.Add(this.label1);
            this.gbxQA.Enabled = false;
            this.gbxQA.Location = new System.Drawing.Point(241, 77);
            this.gbxQA.Name = "gbxQA";
            this.gbxQA.Size = new System.Drawing.Size(712, 417);
            this.gbxQA.TabIndex = 1;
            this.gbxQA.TabStop = false;
            this.gbxQA.Text = "Questions and Answers";
            // 
            // txtCatDisplayName
            // 
            this.txtCatDisplayName.Location = new System.Drawing.Point(597, 248);
            this.txtCatDisplayName.Multiline = true;
            this.txtCatDisplayName.Name = "txtCatDisplayName";
            this.txtCatDisplayName.Size = new System.Drawing.Size(105, 52);
            this.txtCatDisplayName.TabIndex = 34;
            // 
            // txtCatName
            // 
            this.txtCatName.Location = new System.Drawing.Point(528, 222);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(174, 20);
            this.txtCatName.TabIndex = 33;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(510, 248);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(75, 13);
            this.label21.TabIndex = 32;
            this.label21.Text = "Display Name:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(484, 225);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 13);
            this.label20.TabIndex = 31;
            this.label20.Text = "Name:";
            // 
            // gbxPointerInfo
            // 
            this.gbxPointerInfo.Controls.Add(this.lblSnesAddress);
            this.gbxPointerInfo.Controls.Add(this.label19);
            this.gbxPointerInfo.Controls.Add(this.lblPointerBank);
            this.gbxPointerInfo.Controls.Add(this.label18);
            this.gbxPointerInfo.Controls.Add(this.lblPointerAddress);
            this.gbxPointerInfo.Controls.Add(this.label17);
            this.gbxPointerInfo.Controls.Add(this.label16);
            this.gbxPointerInfo.Controls.Add(this.lblPointer);
            this.gbxPointerInfo.Location = new System.Drawing.Point(476, 338);
            this.gbxPointerInfo.Name = "gbxPointerInfo";
            this.gbxPointerInfo.Size = new System.Drawing.Size(230, 73);
            this.gbxPointerInfo.TabIndex = 30;
            this.gbxPointerInfo.TabStop = false;
            this.gbxPointerInfo.Text = "Pointer Info";
            // 
            // lblSnesAddress
            // 
            this.lblSnesAddress.AutoSize = true;
            this.lblSnesAddress.Location = new System.Drawing.Point(139, 53);
            this.lblSnesAddress.Name = "lblSnesAddress";
            this.lblSnesAddress.Size = new System.Drawing.Size(13, 13);
            this.lblSnesAddress.TabIndex = 35;
            this.lblSnesAddress.Text = "?";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(29, 53);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 13);
            this.label19.TabIndex = 34;
            this.label19.Text = "SNES Address:";
            // 
            // lblPointerBank
            // 
            this.lblPointerBank.AutoSize = true;
            this.lblPointerBank.Location = new System.Drawing.Point(139, 40);
            this.lblPointerBank.Name = "lblPointerBank";
            this.lblPointerBank.Size = new System.Drawing.Size(13, 13);
            this.lblPointerBank.TabIndex = 33;
            this.lblPointerBank.Text = "?";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(34, 40);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 13);
            this.label18.TabIndex = 32;
            this.label18.Text = "Memory Bank:";
            // 
            // lblPointerAddress
            // 
            this.lblPointerAddress.AutoSize = true;
            this.lblPointerAddress.Location = new System.Drawing.Point(139, 27);
            this.lblPointerAddress.Name = "lblPointerAddress";
            this.lblPointerAddress.Size = new System.Drawing.Size(13, 13);
            this.lblPointerAddress.TabIndex = 31;
            this.lblPointerAddress.Text = "?";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(61, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "Address:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(58, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Points to:";
            // 
            // lblPointer
            // 
            this.lblPointer.AutoSize = true;
            this.lblPointer.Location = new System.Drawing.Point(139, 14);
            this.lblPointer.Name = "lblPointer";
            this.lblPointer.Size = new System.Drawing.Size(13, 13);
            this.lblPointer.TabIndex = 29;
            this.lblPointer.Text = "?";
            // 
            // lblCatSize
            // 
            this.lblCatSize.AutoSize = true;
            this.lblCatSize.Location = new System.Drawing.Point(615, 322);
            this.lblCatSize.Name = "lblCatSize";
            this.lblCatSize.Size = new System.Drawing.Size(41, 13);
            this.lblCatSize.TabIndex = 27;
            this.lblCatSize.Text = "0 bytes";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(510, 322);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Catagory Size:";
            // 
            // lblCatAddress
            // 
            this.lblCatAddress.AutoSize = true;
            this.lblCatAddress.Location = new System.Drawing.Point(615, 303);
            this.lblCatAddress.Name = "lblCatAddress";
            this.lblCatAddress.Size = new System.Drawing.Size(13, 13);
            this.lblCatAddress.TabIndex = 25;
            this.lblCatAddress.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(492, 303);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Catagory Address:";
            // 
            // txtA5
            // 
            this.txtA5.Location = new System.Drawing.Point(241, 384);
            this.txtA5.Name = "txtA5";
            this.txtA5.Size = new System.Drawing.Size(229, 20);
            this.txtA5.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(238, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Answer:";
            // 
            // txtQ5
            // 
            this.txtQ5.Location = new System.Drawing.Point(241, 241);
            this.txtQ5.Multiline = true;
            this.txtQ5.Name = "txtQ5";
            this.txtQ5.Size = new System.Drawing.Size(122, 124);
            this.txtQ5.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(238, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Question 5:";
            // 
            // txtA4
            // 
            this.txtA4.Location = new System.Drawing.Point(6, 384);
            this.txtA4.Name = "txtA4";
            this.txtA4.Size = new System.Drawing.Size(229, 20);
            this.txtA4.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Answer:";
            // 
            // txtQ4
            // 
            this.txtQ4.Location = new System.Drawing.Point(9, 241);
            this.txtQ4.Multiline = true;
            this.txtQ4.Name = "txtQ4";
            this.txtQ4.Size = new System.Drawing.Size(124, 124);
            this.txtQ4.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Question 4:";
            // 
            // txtA3
            // 
            this.txtA3.Location = new System.Drawing.Point(476, 186);
            this.txtA3.Name = "txtA3";
            this.txtA3.Size = new System.Drawing.Size(226, 20);
            this.txtA3.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Answer:";
            // 
            // txtQ3
            // 
            this.txtQ3.Location = new System.Drawing.Point(476, 41);
            this.txtQ3.Multiline = true;
            this.txtQ3.Name = "txtQ3";
            this.txtQ3.Size = new System.Drawing.Size(124, 124);
            this.txtQ3.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Question 3:";
            // 
            // txtA2
            // 
            this.txtA2.Location = new System.Drawing.Point(241, 186);
            this.txtA2.Name = "txtA2";
            this.txtA2.Size = new System.Drawing.Size(229, 20);
            this.txtA2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Answer:";
            // 
            // txtQ2
            // 
            this.txtQ2.Location = new System.Drawing.Point(241, 41);
            this.txtQ2.Multiline = true;
            this.txtQ2.Name = "txtQ2";
            this.txtQ2.Size = new System.Drawing.Size(124, 124);
            this.txtQ2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Question 2:";
            // 
            // txtA1
            // 
            this.txtA1.Location = new System.Drawing.Point(9, 186);
            this.txtA1.Name = "txtA1";
            this.txtA1.Size = new System.Drawing.Size(226, 20);
            this.txtA1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Answer:";
            // 
            // txtQ1
            // 
            this.txtQ1.Location = new System.Drawing.Point(9, 41);
            this.txtQ1.Multiline = true;
            this.txtQ1.Name = "txtQ1";
            this.txtQ1.Size = new System.Drawing.Size(124, 124);
            this.txtQ1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question 1:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(241, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Free Space:";
            // 
            // lblDeadSpace
            // 
            this.lblDeadSpace.AutoSize = true;
            this.lblDeadSpace.Location = new System.Drawing.Point(361, 48);
            this.lblDeadSpace.Name = "lblDeadSpace";
            this.lblDeadSpace.Size = new System.Drawing.Size(13, 13);
            this.lblDeadSpace.TabIndex = 3;
            this.lblDeadSpace.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(241, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Total Catagories:";
            // 
            // lblTotalCat
            // 
            this.lblTotalCat.AutoSize = true;
            this.lblTotalCat.Location = new System.Drawing.Point(361, 35);
            this.lblTotalCat.Name = "lblTotalCat";
            this.lblTotalCat.Size = new System.Drawing.Size(13, 13);
            this.lblTotalCat.TabIndex = 5;
            this.lblTotalCat.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(241, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Total Size:";
            // 
            // lblSizeChar
            // 
            this.lblSizeChar.AutoSize = true;
            this.lblSizeChar.Location = new System.Drawing.Point(361, 61);
            this.lblSizeChar.Name = "lblSizeChar";
            this.lblSizeChar.Size = new System.Drawing.Size(13, 13);
            this.lblSizeChar.TabIndex = 7;
            this.lblSizeChar.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(963, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpenRom,
            this.menuCloseRom,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.menuLoadXml,
            this.toolStripSeparator2,
            this.menuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuOpenRom
            // 
            this.menuOpenRom.Name = "menuOpenRom";
            this.menuOpenRom.Size = new System.Drawing.Size(131, 22);
            this.menuOpenRom.Text = "Open Rom";
            this.menuOpenRom.Click += new System.EventHandler(this.menuOpenRom_Click);
            // 
            // menuCloseRom
            // 
            this.menuCloseRom.Enabled = false;
            this.menuCloseRom.Name = "menuCloseRom";
            this.menuCloseRom.Size = new System.Drawing.Size(131, 22);
            this.menuCloseRom.Text = "Close Rom";
            this.menuCloseRom.Click += new System.EventHandler(this.menuCloseRom_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(128, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSaveToXml,
            this.menuSaveToRom});
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // menuSaveToXml
            // 
            this.menuSaveToXml.Name = "menuSaveToXml";
            this.menuSaveToXml.Size = new System.Drawing.Size(115, 22);
            this.menuSaveToXml.Text = "To Xml";
            this.menuSaveToXml.Click += new System.EventHandler(this.menuSaveToXml_Click);
            // 
            // menuSaveToRom
            // 
            this.menuSaveToRom.Name = "menuSaveToRom";
            this.menuSaveToRom.Size = new System.Drawing.Size(115, 22);
            this.menuSaveToRom.Text = "To Rom";
            this.menuSaveToRom.Click += new System.EventHandler(this.menuSaveToRom_Click);
            // 
            // menuLoadXml
            // 
            this.menuLoadXml.Enabled = false;
            this.menuLoadXml.Name = "menuLoadXml";
            this.menuLoadXml.Size = new System.Drawing.Size(131, 22);
            this.menuLoadXml.Text = "Load Xml";
            this.menuLoadXml.Click += new System.EventHandler(this.menuLoadXml_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(128, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(131, 22);
            this.menuExit.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.toolStripSeparator3,
            this.rebuildStructureToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.editToolStripMenuItem.Text = "Pointers";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Enabled = false;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.viewToolStripMenuItem.Text = "View List";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(162, 6);
            // 
            // rebuildStructureToolStripMenuItem
            // 
            this.rebuildStructureToolStripMenuItem.Enabled = false;
            this.rebuildStructureToolStripMenuItem.Name = "rebuildStructureToolStripMenuItem";
            this.rebuildStructureToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.rebuildStructureToolStripMenuItem.Text = "Rebuild Structure";
            this.rebuildStructureToolStripMenuItem.Click += new System.EventHandler(this.rebuildStructureToolStripMenuItem_Click);
            // 
            // openRom
            // 
            this.openRom.DefaultExt = "smc";
            // 
            // lblRomName
            // 
            this.lblRomName.AutoSize = true;
            this.lblRomName.Location = new System.Drawing.Point(798, 61);
            this.lblRomName.Name = "lblRomName";
            this.lblRomName.Size = new System.Drawing.Size(85, 13);
            this.lblRomName.TabIndex = 9;
            this.lblRomName.Text = "No Rom Loaded";
            // 
            // lblInvalidPointers
            // 
            this.lblInvalidPointers.AutoSize = true;
            this.lblInvalidPointers.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidPointers.Location = new System.Drawing.Point(798, 35);
            this.lblInvalidPointers.Name = "lblInvalidPointers";
            this.lblInvalidPointers.Size = new System.Drawing.Size(141, 13);
            this.lblInvalidPointers.TabIndex = 10;
            this.lblInvalidPointers.Text = "[UNALAIGNED POINTERS]";
            this.lblInvalidPointers.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 506);
            this.Controls.Add(this.lblInvalidPointers);
            this.Controls.Add(this.lblRomName);
            this.Controls.Add(this.lblSizeChar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblTotalCat);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblDeadSpace);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.gbxQA);
            this.Controls.Add(this.lstCatagories);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(979, 545);
            this.MinimumSize = new System.Drawing.Size(979, 545);
            this.Name = "Form1";
            this.Text = "Jeopardy! Editor for Super Nintendo ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxQA.ResumeLayout(false);
            this.gbxQA.PerformLayout();
            this.gbxPointerInfo.ResumeLayout(false);
            this.gbxPointerInfo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCatagories;
        private System.Windows.Forms.GroupBox gbxQA;
        private System.Windows.Forms.TextBox txtA5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQ5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtA4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQ4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtA3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQ3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtA2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQ2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtA1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQ1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblDeadSpace;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotalCat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblSizeChar;
        private System.Windows.Forms.Label lblCatSize;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblCatAddress;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuOpenRom;
        private System.Windows.Forms.ToolStripMenuItem menuCloseRom;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSaveToXml;
        private System.Windows.Forms.ToolStripMenuItem menuSaveToRom;
        private System.Windows.Forms.ToolStripMenuItem menuLoadXml;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.OpenFileDialog openRom;
        private System.Windows.Forms.Label lblPointer;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox gbxPointerInfo;
        private System.Windows.Forms.Label lblPointerBank;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblPointerAddress;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem rebuildStructureToolStripMenuItem;
        private System.Windows.Forms.Label lblSnesAddress;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblRomName;
        private System.Windows.Forms.TextBox txtCatDisplayName;
        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblInvalidPointers;
    }
}

