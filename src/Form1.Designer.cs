namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataItemsTreeView = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataItemSubTypeLabel = new System.Windows.Forms.Label();
            this.dataItemSubTypeDescription = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataItemTypeLabel = new System.Windows.Forms.Label();
            this.dataItemTypeDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataItemSendButton = new System.Windows.Forms.Button();
            this.sampleValueDataItemKeyTextBox = new System.Windows.Forms.TextBox();
            this.dataItemValuePanel = new System.Windows.Forms.Panel();
            this.dataItemValueDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataItemResultComboBox = new System.Windows.Forms.ComboBox();
            this.dataItemConditionPanel = new System.Windows.Forms.Panel();
            this.dataItemConditionMessageTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dataItemConditionQualifierComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dataItemConditionNativeSeverityTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataItemConditionLevelDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.dataItemConditionNativeCodeTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataItemLevelComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.assetBodyTextBox = new System.Windows.Forms.RichTextBox();
            this.assetSendButton = new System.Windows.Forms.Button();
            this.assetTypeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.assetIdTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.httpPortTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.connectionStatusLabel = new System.Windows.Forms.Label();
            this.shdrPortTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hostnameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.disconnectedPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.deviceComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.dataItemValuePanel.SuspendLayout();
            this.dataItemConditionPanel.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.disconnectedPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(12, 81);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1087, 311);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.dataItemsTreeView);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dataItemSendButton);
            this.tabPage1.Controls.Add(this.sampleValueDataItemKeyTextBox);
            this.tabPage1.Controls.Add(this.dataItemValuePanel);
            this.tabPage1.Controls.Add(this.dataItemConditionPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1079, 283);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DataItem";
            // 
            // dataItemsTreeView
            // 
            this.dataItemsTreeView.Location = new System.Drawing.Point(0, 0);
            this.dataItemsTreeView.Name = "dataItemsTreeView";
            this.dataItemsTreeView.Size = new System.Drawing.Size(339, 273);
            this.dataItemsTreeView.TabIndex = 1;
            this.dataItemsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.dataItemsTreeView_AfterSelect);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataItemSubTypeLabel);
            this.groupBox2.Controls.Add(this.dataItemSubTypeDescription);
            this.groupBox2.Location = new System.Drawing.Point(345, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 117);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SubType";
            // 
            // dataItemSubTypeLabel
            // 
            this.dataItemSubTypeLabel.AutoSize = true;
            this.dataItemSubTypeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dataItemSubTypeLabel.Location = new System.Drawing.Point(6, 19);
            this.dataItemSubTypeLabel.Name = "dataItemSubTypeLabel";
            this.dataItemSubTypeLabel.Size = new System.Drawing.Size(40, 15);
            this.dataItemSubTypeLabel.TabIndex = 7;
            this.dataItemSubTypeLabel.Text = "label9";
            // 
            // dataItemSubTypeDescription
            // 
            this.dataItemSubTypeDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataItemSubTypeDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataItemSubTypeDescription.Location = new System.Drawing.Point(6, 38);
            this.dataItemSubTypeDescription.Multiline = true;
            this.dataItemSubTypeDescription.Name = "dataItemSubTypeDescription";
            this.dataItemSubTypeDescription.Size = new System.Drawing.Size(278, 73);
            this.dataItemSubTypeDescription.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataItemTypeLabel);
            this.groupBox1.Controls.Add(this.dataItemTypeDescriptionTextBox);
            this.groupBox1.Location = new System.Drawing.Point(345, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 144);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // dataItemTypeLabel
            // 
            this.dataItemTypeLabel.AutoSize = true;
            this.dataItemTypeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dataItemTypeLabel.Location = new System.Drawing.Point(6, 19);
            this.dataItemTypeLabel.Name = "dataItemTypeLabel";
            this.dataItemTypeLabel.Size = new System.Drawing.Size(40, 15);
            this.dataItemTypeLabel.TabIndex = 5;
            this.dataItemTypeLabel.Text = "label9";
            // 
            // dataItemTypeDescriptionTextBox
            // 
            this.dataItemTypeDescriptionTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataItemTypeDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataItemTypeDescriptionTextBox.Location = new System.Drawing.Point(6, 37);
            this.dataItemTypeDescriptionTextBox.Multiline = true;
            this.dataItemTypeDescriptionTextBox.Name = "dataItemTypeDescriptionTextBox";
            this.dataItemTypeDescriptionTextBox.Size = new System.Drawing.Size(278, 101);
            this.dataItemTypeDescriptionTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(660, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "DataItemKey (ID or Name)";
            // 
            // dataItemSendButton
            // 
            this.dataItemSendButton.Location = new System.Drawing.Point(988, 245);
            this.dataItemSendButton.Name = "dataItemSendButton";
            this.dataItemSendButton.Size = new System.Drawing.Size(85, 28);
            this.dataItemSendButton.TabIndex = 4;
            this.dataItemSendButton.Text = "Send";
            this.dataItemSendButton.UseVisualStyleBackColor = true;
            this.dataItemSendButton.Click += new System.EventHandler(this.sampleValueSendButton_Click);
            // 
            // sampleValueDataItemKeyTextBox
            // 
            this.sampleValueDataItemKeyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sampleValueDataItemKeyTextBox.Location = new System.Drawing.Point(660, 23);
            this.sampleValueDataItemKeyTextBox.Name = "sampleValueDataItemKeyTextBox";
            this.sampleValueDataItemKeyTextBox.Size = new System.Drawing.Size(404, 23);
            this.sampleValueDataItemKeyTextBox.TabIndex = 1;
            // 
            // dataItemValuePanel
            // 
            this.dataItemValuePanel.Controls.Add(this.dataItemValueDescriptionTextBox);
            this.dataItemValuePanel.Controls.Add(this.label4);
            this.dataItemValuePanel.Controls.Add(this.dataItemResultComboBox);
            this.dataItemValuePanel.Location = new System.Drawing.Point(655, 50);
            this.dataItemValuePanel.Name = "dataItemValuePanel";
            this.dataItemValuePanel.Size = new System.Drawing.Size(410, 187);
            this.dataItemValuePanel.TabIndex = 13;
            // 
            // dataItemValueDescriptionTextBox
            // 
            this.dataItemValueDescriptionTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataItemValueDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataItemValueDescriptionTextBox.Location = new System.Drawing.Point(5, 52);
            this.dataItemValueDescriptionTextBox.Multiline = true;
            this.dataItemValueDescriptionTextBox.Name = "dataItemValueDescriptionTextBox";
            this.dataItemValueDescriptionTextBox.Size = new System.Drawing.Size(404, 132);
            this.dataItemValueDescriptionTextBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Result";
            // 
            // dataItemResultComboBox
            // 
            this.dataItemResultComboBox.FormattingEnabled = true;
            this.dataItemResultComboBox.Location = new System.Drawing.Point(5, 23);
            this.dataItemResultComboBox.Name = "dataItemResultComboBox";
            this.dataItemResultComboBox.Size = new System.Drawing.Size(404, 23);
            this.dataItemResultComboBox.TabIndex = 11;
            this.dataItemResultComboBox.SelectedIndexChanged += new System.EventHandler(this.dataItemResultComboBox_SelectedIndexChanged);
            // 
            // dataItemConditionPanel
            // 
            this.dataItemConditionPanel.Controls.Add(this.dataItemConditionMessageTextBox);
            this.dataItemConditionPanel.Controls.Add(this.label13);
            this.dataItemConditionPanel.Controls.Add(this.dataItemConditionQualifierComboBox);
            this.dataItemConditionPanel.Controls.Add(this.label12);
            this.dataItemConditionPanel.Controls.Add(this.dataItemConditionNativeSeverityTextBox);
            this.dataItemConditionPanel.Controls.Add(this.label11);
            this.dataItemConditionPanel.Controls.Add(this.dataItemConditionLevelDescriptionTextBox);
            this.dataItemConditionPanel.Controls.Add(this.dataItemConditionNativeCodeTextBox);
            this.dataItemConditionPanel.Controls.Add(this.label10);
            this.dataItemConditionPanel.Controls.Add(this.dataItemLevelComboBox);
            this.dataItemConditionPanel.Controls.Add(this.label8);
            this.dataItemConditionPanel.Location = new System.Drawing.Point(655, 50);
            this.dataItemConditionPanel.Name = "dataItemConditionPanel";
            this.dataItemConditionPanel.Size = new System.Drawing.Size(412, 187);
            this.dataItemConditionPanel.TabIndex = 14;
            // 
            // dataItemConditionMessageTextBox
            // 
            this.dataItemConditionMessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataItemConditionMessageTextBox.Location = new System.Drawing.Point(93, 148);
            this.dataItemConditionMessageTextBox.Name = "dataItemConditionMessageTextBox";
            this.dataItemConditionMessageTextBox.Size = new System.Drawing.Size(316, 23);
            this.dataItemConditionMessageTextBox.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 15);
            this.label13.TabIndex = 9;
            this.label13.Text = "Message";
            // 
            // dataItemConditionQualifierComboBox
            // 
            this.dataItemConditionQualifierComboBox.FormattingEnabled = true;
            this.dataItemConditionQualifierComboBox.Items.AddRange(new object[] {
            "HIGH",
            "LOW"});
            this.dataItemConditionQualifierComboBox.Location = new System.Drawing.Point(93, 119);
            this.dataItemConditionQualifierComboBox.Name = "dataItemConditionQualifierComboBox";
            this.dataItemConditionQualifierComboBox.Size = new System.Drawing.Size(316, 23);
            this.dataItemConditionQualifierComboBox.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 15);
            this.label12.TabIndex = 7;
            this.label12.Text = "Qualifier";
            // 
            // dataItemConditionNativeSeverityTextBox
            // 
            this.dataItemConditionNativeSeverityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataItemConditionNativeSeverityTextBox.Location = new System.Drawing.Point(93, 90);
            this.dataItemConditionNativeSeverityTextBox.Name = "dataItemConditionNativeSeverityTextBox";
            this.dataItemConditionNativeSeverityTextBox.Size = new System.Drawing.Size(316, 23);
            this.dataItemConditionNativeSeverityTextBox.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 15);
            this.label11.TabIndex = 5;
            this.label11.Text = "NativeSeverity";
            // 
            // dataItemConditionLevelDescriptionTextBox
            // 
            this.dataItemConditionLevelDescriptionTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataItemConditionLevelDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataItemConditionLevelDescriptionTextBox.Location = new System.Drawing.Point(93, 32);
            this.dataItemConditionLevelDescriptionTextBox.Name = "dataItemConditionLevelDescriptionTextBox";
            this.dataItemConditionLevelDescriptionTextBox.Size = new System.Drawing.Size(316, 16);
            this.dataItemConditionLevelDescriptionTextBox.TabIndex = 4;
            // 
            // dataItemConditionNativeCodeTextBox
            // 
            this.dataItemConditionNativeCodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataItemConditionNativeCodeTextBox.Location = new System.Drawing.Point(93, 59);
            this.dataItemConditionNativeCodeTextBox.Name = "dataItemConditionNativeCodeTextBox";
            this.dataItemConditionNativeCodeTextBox.Size = new System.Drawing.Size(316, 23);
            this.dataItemConditionNativeCodeTextBox.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "NativeCode";
            // 
            // dataItemLevelComboBox
            // 
            this.dataItemLevelComboBox.FormattingEnabled = true;
            this.dataItemLevelComboBox.Items.AddRange(new object[] {
            "NORMAL",
            "WARNING",
            "FAULT",
            "UNAVAILABLE"});
            this.dataItemLevelComboBox.Location = new System.Drawing.Point(93, 3);
            this.dataItemLevelComboBox.Name = "dataItemLevelComboBox";
            this.dataItemLevelComboBox.Size = new System.Drawing.Size(316, 23);
            this.dataItemLevelComboBox.TabIndex = 1;
            this.dataItemLevelComboBox.SelectedIndexChanged += new System.EventHandler(this.dataItemLevelComboBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Level";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.assetBodyTextBox);
            this.tabPage7.Controls.Add(this.assetSendButton);
            this.tabPage7.Controls.Add(this.assetTypeTextBox);
            this.tabPage7.Controls.Add(this.label5);
            this.tabPage7.Controls.Add(this.assetIdTextBox);
            this.tabPage7.Controls.Add(this.label6);
            this.tabPage7.Location = new System.Drawing.Point(4, 24);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1079, 283);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "Asset";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // assetBodyTextBox
            // 
            this.assetBodyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.assetBodyTextBox.Location = new System.Drawing.Point(239, 12);
            this.assetBodyTextBox.Name = "assetBodyTextBox";
            this.assetBodyTextBox.Size = new System.Drawing.Size(640, 166);
            this.assetBodyTextBox.TabIndex = 10;
            this.assetBodyTextBox.Text = "";
            // 
            // assetSendButton
            // 
            this.assetSendButton.Location = new System.Drawing.Point(14, 130);
            this.assetSendButton.Name = "assetSendButton";
            this.assetSendButton.Size = new System.Drawing.Size(75, 23);
            this.assetSendButton.TabIndex = 9;
            this.assetSendButton.Text = "Send";
            this.assetSendButton.UseVisualStyleBackColor = true;
            this.assetSendButton.Click += new System.EventHandler(this.assetSendButton_Click);
            // 
            // assetTypeTextBox
            // 
            this.assetTypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.assetTypeTextBox.Location = new System.Drawing.Point(14, 91);
            this.assetTypeTextBox.Name = "assetTypeTextBox";
            this.assetTypeTextBox.Size = new System.Drawing.Size(196, 23);
            this.assetTypeTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Type";
            // 
            // assetIdTextBox
            // 
            this.assetIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.assetIdTextBox.Location = new System.Drawing.Point(14, 33);
            this.assetIdTextBox.Name = "assetIdTextBox";
            this.assetIdTextBox.Size = new System.Drawing.Size(196, 23);
            this.assetIdTextBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Asset ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.httpPortTextBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.connectButton);
            this.panel1.Controls.Add(this.connectionStatusLabel);
            this.panel1.Controls.Add(this.shdrPortTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.hostnameTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 33);
            this.panel1.TabIndex = 1;
            // 
            // httpPortTextBox
            // 
            this.httpPortTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.httpPortTextBox.Location = new System.Drawing.Point(531, 5);
            this.httpPortTextBox.Name = "httpPortTextBox";
            this.httpPortTextBox.Size = new System.Drawing.Size(100, 23);
            this.httpPortTextBox.TabIndex = 7;
            this.httpPortTextBox.Text = "5000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(465, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "HTTP Port";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(0, 1);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(100, 30);
            this.connectButton.TabIndex = 5;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionStatusLabel.AutoSize = true;
            this.connectionStatusLabel.Location = new System.Drawing.Point(965, 10);
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(104, 15);
            this.connectionStatusLabel.TabIndex = 4;
            this.connectionStatusLabel.Text = "Connection Status";
            this.connectionStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // shdrPortTextBox
            // 
            this.shdrPortTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shdrPortTextBox.Location = new System.Drawing.Point(722, 5);
            this.shdrPortTextBox.Name = "shdrPortTextBox";
            this.shdrPortTextBox.Size = new System.Drawing.Size(100, 23);
            this.shdrPortTextBox.TabIndex = 3;
            this.shdrPortTextBox.Text = "7878";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(654, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "SHDR Port";
            // 
            // hostnameTextBox
            // 
            this.hostnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hostnameTextBox.Location = new System.Drawing.Point(187, 5);
            this.hostnameTextBox.Name = "hostnameTextBox";
            this.hostnameTextBox.Size = new System.Drawing.Size(263, 23);
            this.hostnameTextBox.TabIndex = 1;
            this.hostnameTextBox.Text = "localhost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hostname";
            // 
            // outputListBox
            // 
            this.outputListBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.ItemHeight = 15;
            this.outputListBox.Location = new System.Drawing.Point(4, 349);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(1083, 124);
            this.outputListBox.TabIndex = 2;
            // 
            // disconnectedPanel
            // 
            this.disconnectedPanel.Controls.Add(this.outputListBox);
            this.disconnectedPanel.Controls.Add(this.label7);
            this.disconnectedPanel.Location = new System.Drawing.Point(12, 49);
            this.disconnectedPanel.Name = "disconnectedPanel";
            this.disconnectedPanel.Size = new System.Drawing.Size(1087, 473);
            this.disconnectedPanel.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(462, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Not Connected to Agent";
            // 
            // deviceComboBox
            // 
            this.deviceComboBox.FormattingEnabled = true;
            this.deviceComboBox.Location = new System.Drawing.Point(17, 52);
            this.deviceComboBox.Name = "deviceComboBox";
            this.deviceComboBox.Size = new System.Drawing.Size(164, 23);
            this.deviceComboBox.TabIndex = 1;
            this.deviceComboBox.SelectedIndexChanged += new System.EventHandler(this.deviceComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 534);
            this.Controls.Add(this.deviceComboBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.disconnectedPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "TrakHound MTConnect SHDR Tool";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.dataItemValuePanel.ResumeLayout(false);
            this.dataItemValuePanel.PerformLayout();
            this.dataItemConditionPanel.ResumeLayout(false);
            this.dataItemConditionPanel.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.disconnectedPanel.ResumeLayout(false);
            this.disconnectedPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel panel1;
        private TextBox shdrPortTextBox;
        private Label label2;
        private TextBox hostnameTextBox;
        private Label label1;
        private Label connectionStatusLabel;
        private Button dataItemSendButton;
        private Label label4;
        private TextBox sampleValueDataItemKeyTextBox;
        private Label label3;
        private ListBox outputListBox;
        private Button connectButton;
        private TabPage tabPage7;
        private RichTextBox assetBodyTextBox;
        private Button assetSendButton;
        private TextBox assetTypeTextBox;
        private Label label5;
        private TextBox assetIdTextBox;
        private Label label6;
        private Panel disconnectedPanel;
        private Label label7;
        private TreeView dataItemsTreeView;
        private ComboBox deviceComboBox;
        private TextBox dataItemTypeDescriptionTextBox;
        private Label dataItemTypeLabel;
        private TextBox dataItemSubTypeDescription;
        private Label dataItemSubTypeLabel;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TextBox httpPortTextBox;
        private Label label9;
        private ComboBox dataItemResultComboBox;
        private TextBox dataItemValueDescriptionTextBox;
        private Panel dataItemValuePanel;
        private Panel dataItemConditionPanel;
        private TextBox dataItemConditionMessageTextBox;
        private Label label13;
        private ComboBox dataItemConditionQualifierComboBox;
        private Label label12;
        private TextBox dataItemConditionNativeSeverityTextBox;
        private Label label11;
        private TextBox dataItemConditionLevelDescriptionTextBox;
        private TextBox dataItemConditionNativeCodeTextBox;
        private Label label10;
        private ComboBox dataItemLevelComboBox;
        private Label label8;
    }
}