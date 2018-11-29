namespace Merchant_RPG {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HeroList = new System.Windows.Forms.ListBox();
            this.HeroChooser = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LevelPicker = new System.Windows.Forms.DomainUpDown();
            this.HeroNameLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.att_dex_label = new System.Windows.Forms.Label();
            this.att_int_label = new System.Windows.Forms.Label();
            this.att_str_label = new System.Windows.Forms.Label();
            this.att_dex = new System.Windows.Forms.TextBox();
            this.att_int = new System.Windows.Forms.TextBox();
            this.att_str = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.att_dmg = new System.Windows.Forms.TextBox();
            this.att_exp = new System.Windows.Forms.Label();
            this.att_luck = new System.Windows.Forms.Label();
            this.att_dmg_label = new System.Windows.Forms.Label();
            this.att_mdef_label = new System.Windows.Forms.Label();
            this.att_pdef_label = new System.Windows.Forms.Label();
            this.att_crit_label = new System.Windows.Forms.Label();
            this.att_acc_label = new System.Windows.Forms.Label();
            this.att_matk_label = new System.Windows.Forms.Label();
            this.att_patk_label = new System.Windows.Forms.Label();
            this.att_mdef = new System.Windows.Forms.TextBox();
            this.att_pdef = new System.Windows.Forms.TextBox();
            this.att_crit = new System.Windows.Forms.TextBox();
            this.att_acc = new System.Windows.Forms.TextBox();
            this.att_matk = new System.Windows.Forms.TextBox();
            this.att_patk = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Equip_trinket_label = new System.Windows.Forms.Label();
            this.Equip_boots_label = new System.Windows.Forms.Label();
            this.Equip_gloves_label = new System.Windows.Forms.Label();
            this.Equip_chest_label = new System.Windows.Forms.Label();
            this.Equip_helm_label = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Equip_weapon_label = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(764, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // HeroList
            // 
            this.HeroList.FormattingEnabled = true;
            this.HeroList.Location = new System.Drawing.Point(0, 67);
            this.HeroList.Name = "HeroList";
            this.HeroList.Size = new System.Drawing.Size(120, 95);
            this.HeroList.TabIndex = 1;
            this.HeroList.SelectedIndexChanged += new System.EventHandler(this.HeroList_SelectedIndexChanged_1);
            // 
            // HeroChooser
            // 
            this.HeroChooser.FormattingEnabled = true;
            this.HeroChooser.Location = new System.Drawing.Point(0, 40);
            this.HeroChooser.Name = "HeroChooser";
            this.HeroChooser.Size = new System.Drawing.Size(121, 21);
            this.HeroChooser.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(142, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(142, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LevelPicker
            // 
            this.LevelPicker.Location = new System.Drawing.Point(32, 67);
            this.LevelPicker.Name = "LevelPicker";
            this.LevelPicker.Size = new System.Drawing.Size(120, 20);
            this.LevelPicker.TabIndex = 5;
            this.LevelPicker.Text = "Level";
            this.LevelPicker.SelectedItemChanged += new System.EventHandler(this.LevelPicker_SelectedItemChanged);
            // 
            // HeroNameLabel
            // 
            this.HeroNameLabel.AutoSize = true;
            this.HeroNameLabel.Location = new System.Drawing.Point(29, 37);
            this.HeroNameLabel.Name = "HeroNameLabel";
            this.HeroNameLabel.Size = new System.Drawing.Size(58, 13);
            this.HeroNameLabel.TabIndex = 6;
            this.HeroNameLabel.Text = "HeroName";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.att_dex_label);
            this.groupBox1.Controls.Add(this.att_int_label);
            this.groupBox1.Controls.Add(this.att_str_label);
            this.groupBox1.Controls.Add(this.att_dex);
            this.groupBox1.Controls.Add(this.att_int);
            this.groupBox1.Controls.Add(this.att_str);
            this.groupBox1.Location = new System.Drawing.Point(195, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 87);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attributes";
            // 
            // att_dex_label
            // 
            this.att_dex_label.AutoSize = true;
            this.att_dex_label.Location = new System.Drawing.Point(215, 20);
            this.att_dex_label.Name = "att_dex_label";
            this.att_dex_label.Size = new System.Drawing.Size(48, 13);
            this.att_dex_label.TabIndex = 5;
            this.att_dex_label.Text = "Dexterity";
            // 
            // att_int_label
            // 
            this.att_int_label.AutoSize = true;
            this.att_int_label.Location = new System.Drawing.Point(114, 20);
            this.att_int_label.Name = "att_int_label";
            this.att_int_label.Size = new System.Drawing.Size(61, 13);
            this.att_int_label.TabIndex = 4;
            this.att_int_label.Text = "Intelligence";
            // 
            // att_str_label
            // 
            this.att_str_label.AutoSize = true;
            this.att_str_label.Location = new System.Drawing.Point(13, 20);
            this.att_str_label.Name = "att_str_label";
            this.att_str_label.Size = new System.Drawing.Size(47, 13);
            this.att_str_label.TabIndex = 3;
            this.att_str_label.Text = "Strength";
            // 
            // att_dex
            // 
            this.att_dex.Location = new System.Drawing.Point(218, 50);
            this.att_dex.Name = "att_dex";
            this.att_dex.Size = new System.Drawing.Size(60, 20);
            this.att_dex.TabIndex = 2;
            // 
            // att_int
            // 
            this.att_int.Location = new System.Drawing.Point(117, 50);
            this.att_int.Name = "att_int";
            this.att_int.Size = new System.Drawing.Size(60, 20);
            this.att_int.TabIndex = 1;
            // 
            // att_str
            // 
            this.att_str.Location = new System.Drawing.Point(16, 50);
            this.att_str.Name = "att_str";
            this.att_str.Size = new System.Drawing.Size(60, 20);
            this.att_str.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.att_dmg);
            this.groupBox2.Controls.Add(this.att_exp);
            this.groupBox2.Controls.Add(this.att_luck);
            this.groupBox2.Controls.Add(this.att_dmg_label);
            this.groupBox2.Controls.Add(this.att_mdef_label);
            this.groupBox2.Controls.Add(this.att_pdef_label);
            this.groupBox2.Controls.Add(this.att_crit_label);
            this.groupBox2.Controls.Add(this.att_acc_label);
            this.groupBox2.Controls.Add(this.att_matk_label);
            this.groupBox2.Controls.Add(this.att_patk_label);
            this.groupBox2.Controls.Add(this.att_mdef);
            this.groupBox2.Controls.Add(this.att_pdef);
            this.groupBox2.Controls.Add(this.att_crit);
            this.groupBox2.Controls.Add(this.att_acc);
            this.groupBox2.Controls.Add(this.att_matk);
            this.groupBox2.Controls.Add(this.att_patk);
            this.groupBox2.Location = new System.Drawing.Point(32, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 187);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Main Stats";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(301, 144);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(301, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 16;
            // 
            // att_dmg
            // 
            this.att_dmg.Location = new System.Drawing.Point(301, 42);
            this.att_dmg.Name = "att_dmg";
            this.att_dmg.Size = new System.Drawing.Size(100, 20);
            this.att_dmg.TabIndex = 15;
            // 
            // att_exp
            // 
            this.att_exp.AutoSize = true;
            this.att_exp.Location = new System.Drawing.Point(301, 122);
            this.att_exp.Name = "att_exp";
            this.att_exp.Size = new System.Drawing.Size(87, 13);
            this.att_exp.TabIndex = 14;
            this.att_exp.Text = "Extra Experience";
            // 
            // att_luck
            // 
            this.att_luck.AutoSize = true;
            this.att_luck.Location = new System.Drawing.Point(301, 71);
            this.att_luck.Name = "att_luck";
            this.att_luck.Size = new System.Drawing.Size(31, 13);
            this.att_luck.TabIndex = 13;
            this.att_luck.Text = "Luck";
            // 
            // att_dmg_label
            // 
            this.att_dmg_label.AutoSize = true;
            this.att_dmg_label.Location = new System.Drawing.Point(301, 20);
            this.att_dmg_label.Name = "att_dmg_label";
            this.att_dmg_label.Size = new System.Drawing.Size(47, 13);
            this.att_dmg_label.TabIndex = 12;
            this.att_dmg_label.Text = "Damage";
            // 
            // att_mdef_label
            // 
            this.att_mdef_label.AutoSize = true;
            this.att_mdef_label.Location = new System.Drawing.Point(160, 122);
            this.att_mdef_label.Name = "att_mdef_label";
            this.att_mdef_label.Size = new System.Drawing.Size(87, 13);
            this.att_mdef_label.TabIndex = 11;
            this.att_mdef_label.Text = "Magical Defense";
            // 
            // att_pdef_label
            // 
            this.att_pdef_label.AutoSize = true;
            this.att_pdef_label.Location = new System.Drawing.Point(160, 71);
            this.att_pdef_label.Name = "att_pdef_label";
            this.att_pdef_label.Size = new System.Drawing.Size(89, 13);
            this.att_pdef_label.TabIndex = 10;
            this.att_pdef_label.Text = "Physical Defense";
            // 
            // att_crit_label
            // 
            this.att_crit_label.AutoSize = true;
            this.att_crit_label.Location = new System.Drawing.Point(160, 20);
            this.att_crit_label.Name = "att_crit_label";
            this.att_crit_label.Size = new System.Drawing.Size(94, 13);
            this.att_crit_label.TabIndex = 9;
            this.att_crit_label.Text = "Critical Hit Chance";
            // 
            // att_acc_label
            // 
            this.att_acc_label.AutoSize = true;
            this.att_acc_label.Location = new System.Drawing.Point(19, 122);
            this.att_acc_label.Name = "att_acc_label";
            this.att_acc_label.Size = new System.Drawing.Size(52, 13);
            this.att_acc_label.TabIndex = 8;
            this.att_acc_label.Text = "Accuracy";
            // 
            // att_matk_label
            // 
            this.att_matk_label.AutoSize = true;
            this.att_matk_label.Location = new System.Drawing.Point(19, 71);
            this.att_matk_label.Name = "att_matk_label";
            this.att_matk_label.Size = new System.Drawing.Size(78, 13);
            this.att_matk_label.TabIndex = 7;
            this.att_matk_label.Text = "Magical Attack";
            // 
            // att_patk_label
            // 
            this.att_patk_label.AutoSize = true;
            this.att_patk_label.Location = new System.Drawing.Point(19, 20);
            this.att_patk_label.Name = "att_patk_label";
            this.att_patk_label.Size = new System.Drawing.Size(80, 13);
            this.att_patk_label.TabIndex = 6;
            this.att_patk_label.Text = "Physical Attack";
            // 
            // att_mdef
            // 
            this.att_mdef.Location = new System.Drawing.Point(160, 144);
            this.att_mdef.Name = "att_mdef";
            this.att_mdef.Size = new System.Drawing.Size(100, 20);
            this.att_mdef.TabIndex = 5;
            // 
            // att_pdef
            // 
            this.att_pdef.Location = new System.Drawing.Point(160, 93);
            this.att_pdef.Name = "att_pdef";
            this.att_pdef.Size = new System.Drawing.Size(100, 20);
            this.att_pdef.TabIndex = 4;
            // 
            // att_crit
            // 
            this.att_crit.Location = new System.Drawing.Point(160, 42);
            this.att_crit.Name = "att_crit";
            this.att_crit.Size = new System.Drawing.Size(100, 20);
            this.att_crit.TabIndex = 3;
            // 
            // att_acc
            // 
            this.att_acc.Location = new System.Drawing.Point(19, 144);
            this.att_acc.Name = "att_acc";
            this.att_acc.Size = new System.Drawing.Size(100, 20);
            this.att_acc.TabIndex = 2;
            // 
            // att_matk
            // 
            this.att_matk.Location = new System.Drawing.Point(19, 93);
            this.att_matk.Name = "att_matk";
            this.att_matk.Size = new System.Drawing.Size(100, 20);
            this.att_matk.TabIndex = 1;
            // 
            // att_patk
            // 
            this.att_patk.Location = new System.Drawing.Point(19, 42);
            this.att_patk.Name = "att_patk";
            this.att_patk.Size = new System.Drawing.Size(100, 20);
            this.att_patk.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(171, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(593, 376);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.LevelPicker);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.HeroNameLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(585, 350);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Attribute";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Equip_trinket_label);
            this.tabPage2.Controls.Add(this.Equip_boots_label);
            this.tabPage2.Controls.Add(this.Equip_gloves_label);
            this.tabPage2.Controls.Add(this.Equip_chest_label);
            this.tabPage2.Controls.Add(this.Equip_helm_label);
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.Equip_weapon_label);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(585, 350);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Equipment";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Equip_trinket_label
            // 
            this.Equip_trinket_label.AutoSize = true;
            this.Equip_trinket_label.Location = new System.Drawing.Point(117, 301);
            this.Equip_trinket_label.Name = "Equip_trinket_label";
            this.Equip_trinket_label.Size = new System.Drawing.Size(35, 13);
            this.Equip_trinket_label.TabIndex = 12;
            this.Equip_trinket_label.Text = "label5";
            // 
            // Equip_boots_label
            // 
            this.Equip_boots_label.AutoSize = true;
            this.Equip_boots_label.Location = new System.Drawing.Point(117, 244);
            this.Equip_boots_label.Name = "Equip_boots_label";
            this.Equip_boots_label.Size = new System.Drawing.Size(35, 13);
            this.Equip_boots_label.TabIndex = 11;
            this.Equip_boots_label.Text = "label4";
            // 
            // Equip_gloves_label
            // 
            this.Equip_gloves_label.AutoSize = true;
            this.Equip_gloves_label.Location = new System.Drawing.Point(117, 187);
            this.Equip_gloves_label.Name = "Equip_gloves_label";
            this.Equip_gloves_label.Size = new System.Drawing.Size(35, 13);
            this.Equip_gloves_label.TabIndex = 10;
            this.Equip_gloves_label.Text = "label3";
            // 
            // Equip_chest_label
            // 
            this.Equip_chest_label.AutoSize = true;
            this.Equip_chest_label.Location = new System.Drawing.Point(117, 130);
            this.Equip_chest_label.Name = "Equip_chest_label";
            this.Equip_chest_label.Size = new System.Drawing.Size(35, 13);
            this.Equip_chest_label.TabIndex = 9;
            this.Equip_chest_label.Text = "label2";
            // 
            // Equip_helm_label
            // 
            this.Equip_helm_label.AutoSize = true;
            this.Equip_helm_label.Location = new System.Drawing.Point(117, 73);
            this.Equip_helm_label.Name = "Equip_helm_label";
            this.Equip_helm_label.Size = new System.Drawing.Size(35, 13);
            this.Equip_helm_label.TabIndex = 8;
            this.Equip_helm_label.Text = "label1";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(21, 301);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 7;
            this.button9.Text = "Trinket";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(21, 244);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 6;
            this.button8.Text = "Boots";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(21, 187);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 5;
            this.button7.Text = "Gloves";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(21, 130);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 4;
            this.button6.Text = "Chest";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(21, 73);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Helm";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Equip_weapon_label
            // 
            this.Equip_weapon_label.AutoSize = true;
            this.Equip_weapon_label.Location = new System.Drawing.Point(117, 16);
            this.Equip_weapon_label.Name = "Equip_weapon_label";
            this.Equip_weapon_label.Size = new System.Drawing.Size(35, 13);
            this.Equip_weapon_label.TabIndex = 2;
            this.Equip_weapon_label.Text = "label1";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(21, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Weapon";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(585, 350);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Skills";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 388);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HeroChooser);
            this.Controls.Add(this.HeroList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox HeroList;
        private System.Windows.Forms.ComboBox HeroChooser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DomainUpDown LevelPicker;
        private System.Windows.Forms.Label HeroNameLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label att_dex_label;
        private System.Windows.Forms.Label att_int_label;
        private System.Windows.Forms.Label att_str_label;
        private System.Windows.Forms.TextBox att_dex;
        private System.Windows.Forms.TextBox att_int;
        private System.Windows.Forms.TextBox att_str;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox att_dmg;
        private System.Windows.Forms.Label att_exp;
        private System.Windows.Forms.Label att_luck;
        private System.Windows.Forms.Label att_dmg_label;
        private System.Windows.Forms.Label att_mdef_label;
        private System.Windows.Forms.Label att_pdef_label;
        private System.Windows.Forms.Label att_crit_label;
        private System.Windows.Forms.Label att_acc_label;
        private System.Windows.Forms.Label att_matk_label;
        private System.Windows.Forms.Label att_patk_label;
        private System.Windows.Forms.TextBox att_mdef;
        private System.Windows.Forms.TextBox att_pdef;
        private System.Windows.Forms.TextBox att_crit;
        private System.Windows.Forms.TextBox att_acc;
        private System.Windows.Forms.TextBox att_matk;
        private System.Windows.Forms.TextBox att_patk;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label Equip_weapon_label;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label Equip_trinket_label;
        private System.Windows.Forms.Label Equip_boots_label;
        private System.Windows.Forms.Label Equip_gloves_label;
        private System.Windows.Forms.Label Equip_chest_label;
        private System.Windows.Forms.Label Equip_helm_label;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}

