﻿namespace GH3MLGUI.Forms
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            modsListView = new ListView();
            nameColumHeader = new ColumnHeader();
            authorColumnHeader = new ColumnHeader();
            versionColumnHeader = new ColumnHeader();
            tagsColumnHeader = new ColumnHeader();
            textBox1 = new TextBox();
            descriptionGroupBox = new GroupBox();
            mainTabControl = new TabControl();
            modsTabPage = new TabPage();
            refreshModListButton = new Button();
            moveModToBottomButton = new Button();
            moveModDownButton = new Button();
            removeModButton = new Button();
            addModButton = new Button();
            moveModUpButton = new Button();
            moveModToTopButton = new Button();
            tabPage2 = new TabPage();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            tabPage1 = new TabPage();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label3 = new Label();
            numericUpDown3 = new NumericUpDown();
            checkBox4 = new CheckBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label2 = new Label();
            groupBox1 = new GroupBox();
            windowStyleComboBox = new ComboBox();
            windowResolutionXNumericUpDown = new NumericUpDown();
            resizableCheckBox = new CheckBox();
            windowResolutionYNumericUpDown = new NumericUpDown();
            label4 = new Label();
            vsyncCheckBox = new CheckBox();
            label1 = new Label();
            commonToolTip = new ToolTip(components);
            button1 = new Button();
            launchButton = new Button();
            descriptionGroupBox.SuspendLayout();
            mainTabControl.SuspendLayout();
            modsTabPage.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)windowResolutionXNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)windowResolutionYNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // modsListView
            // 
            modsListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            modsListView.CheckBoxes = true;
            modsListView.Columns.AddRange(new ColumnHeader[] { nameColumHeader, authorColumnHeader, versionColumnHeader, tagsColumnHeader });
            modsListView.FullRowSelect = true;
            modsListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            modsListView.Location = new Point(6, 3);
            modsListView.MultiSelect = false;
            modsListView.Name = "modsListView";
            modsListView.ShowItemToolTips = true;
            modsListView.Size = new Size(489, 264);
            modsListView.TabIndex = 0;
            modsListView.UseCompatibleStateImageBehavior = false;
            modsListView.View = View.Details;
            modsListView.SelectedIndexChanged += modsListView_SelectedIndexChanged;
            // 
            // nameColumHeader
            // 
            nameColumHeader.Text = "Name";
            nameColumHeader.Width = 100;
            // 
            // authorColumnHeader
            // 
            authorColumnHeader.Text = "Author";
            authorColumnHeader.TextAlign = HorizontalAlignment.Center;
            authorColumnHeader.Width = 100;
            // 
            // versionColumnHeader
            // 
            versionColumnHeader.Text = "Version";
            versionColumnHeader.TextAlign = HorizontalAlignment.Center;
            versionColumnHeader.Width = 100;
            // 
            // tagsColumnHeader
            // 
            tagsColumnHeader.Text = "Tags";
            tagsColumnHeader.TextAlign = HorizontalAlignment.Center;
            tagsColumnHeader.Width = 100;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 19);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(513, 78);
            textBox1.TabIndex = 1;
            // 
            // descriptionGroupBox
            // 
            descriptionGroupBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            descriptionGroupBox.Controls.Add(textBox1);
            descriptionGroupBox.Location = new Point(6, 273);
            descriptionGroupBox.Name = "descriptionGroupBox";
            descriptionGroupBox.Size = new Size(519, 100);
            descriptionGroupBox.TabIndex = 2;
            descriptionGroupBox.TabStop = false;
            descriptionGroupBox.Text = "Description";
            // 
            // mainTabControl
            // 
            mainTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainTabControl.Controls.Add(modsTabPage);
            mainTabControl.Controls.Add(tabPage2);
            mainTabControl.Controls.Add(tabPage1);
            mainTabControl.Location = new Point(12, 12);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(539, 408);
            mainTabControl.TabIndex = 4;
            // 
            // modsTabPage
            // 
            modsTabPage.Controls.Add(refreshModListButton);
            modsTabPage.Controls.Add(moveModToBottomButton);
            modsTabPage.Controls.Add(moveModDownButton);
            modsTabPage.Controls.Add(removeModButton);
            modsTabPage.Controls.Add(addModButton);
            modsTabPage.Controls.Add(modsListView);
            modsTabPage.Controls.Add(moveModUpButton);
            modsTabPage.Controls.Add(descriptionGroupBox);
            modsTabPage.Controls.Add(moveModToTopButton);
            modsTabPage.Location = new Point(4, 25);
            modsTabPage.Name = "modsTabPage";
            modsTabPage.Padding = new Padding(3);
            modsTabPage.Size = new Size(531, 379);
            modsTabPage.TabIndex = 0;
            modsTabPage.Text = "Mods";
            modsTabPage.UseVisualStyleBackColor = true;
            // 
            // refreshModListButton
            // 
            refreshModListButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            refreshModListButton.Image = Properties.Resources.Refresh_16x;
            refreshModListButton.Location = new Point(501, 6);
            refreshModListButton.Name = "refreshModListButton";
            refreshModListButton.Size = new Size(24, 24);
            refreshModListButton.TabIndex = 8;
            commonToolTip.SetToolTip(refreshModListButton, "Refresh the current Mod List");
            refreshModListButton.UseVisualStyleBackColor = true;
            refreshModListButton.Click += refreshModListButton_Click;
            // 
            // moveModToBottomButton
            // 
            moveModToBottomButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            moveModToBottomButton.Image = Properties.Resources.MoveToBottom_16x;
            moveModToBottomButton.Location = new Point(501, 126);
            moveModToBottomButton.Name = "moveModToBottomButton";
            moveModToBottomButton.Size = new Size(24, 24);
            moveModToBottomButton.TabIndex = 9;
            commonToolTip.SetToolTip(moveModToBottomButton, "Move the selected mod to the bottom");
            moveModToBottomButton.UseVisualStyleBackColor = true;
            moveModToBottomButton.Click += moveModToBottomButton_Click;
            // 
            // moveModDownButton
            // 
            moveModDownButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            moveModDownButton.Image = Properties.Resources.MoveDown_16x;
            moveModDownButton.Location = new Point(501, 96);
            moveModDownButton.Name = "moveModDownButton";
            moveModDownButton.Size = new Size(24, 24);
            moveModDownButton.TabIndex = 8;
            commonToolTip.SetToolTip(moveModDownButton, "Move the selected mod down");
            moveModDownButton.UseVisualStyleBackColor = true;
            moveModDownButton.Click += moveModDownButton_Click;
            // 
            // removeModButton
            // 
            removeModButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            removeModButton.Image = Properties.Resources.Remove_16x;
            removeModButton.Location = new Point(501, 243);
            removeModButton.Name = "removeModButton";
            removeModButton.Size = new Size(24, 24);
            removeModButton.TabIndex = 7;
            commonToolTip.SetToolTip(removeModButton, "Remove the selected mod");
            removeModButton.UseVisualStyleBackColor = true;
            removeModButton.Click += removeModButton_Click;
            // 
            // addModButton
            // 
            addModButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addModButton.Image = Properties.Resources.Add_16x;
            addModButton.Location = new Point(501, 213);
            addModButton.Name = "addModButton";
            addModButton.Size = new Size(24, 24);
            addModButton.TabIndex = 7;
            commonToolTip.SetToolTip(addModButton, "Add a new mod");
            addModButton.UseVisualStyleBackColor = true;
            addModButton.Click += addModButton_Click;
            // 
            // moveModUpButton
            // 
            moveModUpButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            moveModUpButton.Image = Properties.Resources.MoveUp_16x;
            moveModUpButton.Location = new Point(501, 66);
            moveModUpButton.Name = "moveModUpButton";
            moveModUpButton.Size = new Size(24, 24);
            moveModUpButton.TabIndex = 6;
            commonToolTip.SetToolTip(moveModUpButton, "Move the selected mod up");
            moveModUpButton.UseVisualStyleBackColor = true;
            moveModUpButton.Click += moveModUpButton_Click;
            // 
            // moveModToTopButton
            // 
            moveModToTopButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            moveModToTopButton.Image = Properties.Resources.MoveToTop_16x;
            moveModToTopButton.Location = new Point(501, 36);
            moveModToTopButton.Name = "moveModToTopButton";
            moveModToTopButton.Size = new Size(24, 24);
            moveModToTopButton.TabIndex = 5;
            commonToolTip.SetToolTip(moveModToTopButton, "Move the selected mod to the top");
            moveModToTopButton.UseVisualStyleBackColor = true;
            moveModToTopButton.Click += moveModToTopButton_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(linkLabel2);
            tabPage2.Controls.Add(linkLabel1);
            tabPage2.Location = new Point(4, 25);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(531, 379);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mod Loader";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(29, 122);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(60, 16);
            linkLabel2.TabIndex = 1;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "linkLabel2";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(6, 74);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(59, 16);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "linkLabel1";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 25);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(531, 379);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Game Options";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(numericUpDown3);
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(numericUpDown2);
            groupBox2.Controls.Add(label2);
            groupBox2.Enabled = false;
            groupBox2.Location = new Point(6, 92);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(517, 116);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "DirectX Options";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 76);
            label5.Name = "label5";
            label5.Size = new Size(84, 16);
            label5.TabIndex = 11;
            label5.Text = "Not Yet Ready!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 52);
            label3.Name = "label3";
            label3.Size = new Size(62, 16);
            label3.TabIndex = 2;
            label3.Text = "Framerate:";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(130, 50);
            numericUpDown3.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            numericUpDown3.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(71, 23);
            numericUpDown3.TabIndex = 3;
            numericUpDown3.TextAlign = HorizontalAlignment.Right;
            numericUpDown3.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(10, 22);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(114, 20);
            checkBox4.TabIndex = 10;
            checkBox4.Text = "Force Resolution";
            commonToolTip.SetToolTip(checkBox4, "Is the window resizable? In other words, does it have a border?");
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(130, 21);
            numericUpDown1.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 800, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(71, 23);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.TextAlign = HorizontalAlignment.Right;
            numericUpDown1.Value = new decimal(new int[] { 1920, 0, 0, 0 });
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(226, 21);
            numericUpDown2.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 600, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(71, 23);
            numericUpDown2.TabIndex = 3;
            numericUpDown2.TextAlign = HorizontalAlignment.Right;
            numericUpDown2.Value = new decimal(new int[] { 1080, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 23);
            label2.Name = "label2";
            label2.Size = new Size(13, 16);
            label2.TabIndex = 4;
            label2.Text = "x";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(windowStyleComboBox);
            groupBox1.Controls.Add(windowResolutionXNumericUpDown);
            groupBox1.Controls.Add(resizableCheckBox);
            groupBox1.Controls.Add(windowResolutionYNumericUpDown);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(vsyncCheckBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(517, 81);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Window Settings";
            // 
            // windowStyleComboBox
            // 
            windowStyleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            windowStyleComboBox.FormattingEnabled = true;
            windowStyleComboBox.Location = new Point(6, 22);
            windowStyleComboBox.Name = "windowStyleComboBox";
            windowStyleComboBox.Size = new Size(170, 24);
            windowStyleComboBox.TabIndex = 11;
            windowStyleComboBox.SelectedIndexChanged += windowStyleComboBox_SelectedIndexChanged;
            // 
            // windowResolutionXNumericUpDown
            // 
            windowResolutionXNumericUpDown.Location = new Point(78, 52);
            windowResolutionXNumericUpDown.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            windowResolutionXNumericUpDown.Minimum = new decimal(new int[] { 800, 0, 0, 0 });
            windowResolutionXNumericUpDown.Name = "windowResolutionXNumericUpDown";
            windowResolutionXNumericUpDown.Size = new Size(71, 23);
            windowResolutionXNumericUpDown.TabIndex = 11;
            windowResolutionXNumericUpDown.TextAlign = HorizontalAlignment.Right;
            windowResolutionXNumericUpDown.Value = new decimal(new int[] { 1920, 0, 0, 0 });
            windowResolutionXNumericUpDown.ValueChanged += windowResolutionXNumericUpDown_ValueChanged;
            // 
            // resizableCheckBox
            // 
            resizableCheckBox.AutoSize = true;
            resizableCheckBox.Location = new Point(425, 22);
            resizableCheckBox.Name = "resizableCheckBox";
            resizableCheckBox.Size = new Size(74, 20);
            resizableCheckBox.TabIndex = 9;
            resizableCheckBox.Text = "Resizable";
            commonToolTip.SetToolTip(resizableCheckBox, "Is the window resizable? In other words, does it have a border?");
            resizableCheckBox.UseVisualStyleBackColor = true;
            // 
            // windowResolutionYNumericUpDown
            // 
            windowResolutionYNumericUpDown.Location = new Point(174, 52);
            windowResolutionYNumericUpDown.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            windowResolutionYNumericUpDown.Minimum = new decimal(new int[] { 600, 0, 0, 0 });
            windowResolutionYNumericUpDown.Name = "windowResolutionYNumericUpDown";
            windowResolutionYNumericUpDown.Size = new Size(71, 23);
            windowResolutionYNumericUpDown.TabIndex = 12;
            windowResolutionYNumericUpDown.TextAlign = HorizontalAlignment.Right;
            windowResolutionYNumericUpDown.Value = new decimal(new int[] { 1080, 0, 0, 0 });
            windowResolutionYNumericUpDown.ValueChanged += windowResolutionYNumericUpDown_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(155, 55);
            label4.Name = "label4";
            label4.Size = new Size(13, 16);
            label4.TabIndex = 13;
            label4.Text = "x";
            // 
            // vsyncCheckBox
            // 
            vsyncCheckBox.AutoSize = true;
            vsyncCheckBox.Checked = true;
            vsyncCheckBox.CheckState = CheckState.Checked;
            vsyncCheckBox.Enabled = false;
            vsyncCheckBox.Location = new Point(182, 24);
            vsyncCheckBox.Name = "vsyncCheckBox";
            vsyncCheckBox.Size = new Size(63, 20);
            vsyncCheckBox.TabIndex = 8;
            vsyncCheckBox.Text = "V-Sync";
            commonToolTip.SetToolTip(vsyncCheckBox, "Enables/Disables V-Sync\r\n(EXPERIMENTAL)");
            vsyncCheckBox.UseVisualStyleBackColor = true;
            vsyncCheckBox.CheckedChanged += vsyncCheckBox_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 55);
            label1.Name = "label1";
            label1.Size = new Size(66, 16);
            label1.TabIndex = 1;
            label1.Text = "Resolution:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Image = Properties.Resources.Save_16x;
            button1.Location = new Point(527, 426);
            button1.Name = "button1";
            button1.Size = new Size(24, 24);
            button1.TabIndex = 8;
            commonToolTip.SetToolTip(button1, "Add a new mod");
            button1.UseVisualStyleBackColor = true;
            // 
            // launchButton
            // 
            launchButton.Location = new Point(12, 426);
            launchButton.Name = "launchButton";
            launchButton.Size = new Size(509, 24);
            launchButton.TabIndex = 5;
            launchButton.Text = "Ready to Rock!";
            launchButton.UseVisualStyleBackColor = true;
            launchButton.Click += launchButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 461);
            Controls.Add(button1);
            Controls.Add(launchButton);
            Controls.Add(mainTabControl);
            Name = "MainForm";
            Text = "Nylon Configuration Tool - Vultumast";
            Load += MainForm_Load;
            descriptionGroupBox.ResumeLayout(false);
            descriptionGroupBox.PerformLayout();
            mainTabControl.ResumeLayout(false);
            modsTabPage.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)windowResolutionXNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)windowResolutionYNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListView modsListView;
        private ColumnHeader nameColumHeader;
        private ColumnHeader authorColumnHeader;
        private ColumnHeader versionColumnHeader;
        private ColumnHeader tagsColumnHeader;
        private TextBox textBox1;
        private GroupBox descriptionGroupBox;
        private TabControl mainTabControl;
        private TabPage modsTabPage;
        private TabPage tabPage2;
        private ToolTip commonToolTip;
        private Button moveModToTopButton;
        private Button moveModUpButton;
        private Button moveModDownButton;
        private Button removeModButton;
        private Button addModButton;
        private Button moveModToBottomButton;
        private Button refreshModListButton;
        private Button launchButton;
        private TabPage tabPage1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private CheckBox vsyncCheckBox;
        private Label label3;
        private NumericUpDown numericUpDown3;
        private CheckBox checkBox4;
        private NumericUpDown windowResolutionXNumericUpDown;
        private NumericUpDown windowResolutionYNumericUpDown;
        private Label label4;
        private Button button1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private ComboBox windowStyleComboBox;
        private CheckBox resizableCheckBox;
        private Label label5;
    }
}