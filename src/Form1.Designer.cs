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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.sampleValueSendButton = new System.Windows.Forms.Button();
            this.sampleValueResultTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sampleValueDataItemKeyTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataSetDataGridView = new System.Windows.Forms.DataGridView();
            this.keyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removedColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataSetSendButton = new System.Windows.Forms.Button();
            this.dataSetDataItemKeyTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.assetBodyTextBox = new System.Windows.Forms.RichTextBox();
            this.assetSendButton = new System.Windows.Forms.Button();
            this.assetTypeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.assetIdTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.connectButton = new System.Windows.Forms.Button();
            this.connectionStatusLabel = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hostnameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDataGridView)).BeginInit();
            this.tabPage7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(16, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(899, 222);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(891, 194);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sample";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(895, 198);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.sampleValueSendButton);
            this.tabPage3.Controls.Add(this.sampleValueResultTextBox);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.sampleValueDataItemKeyTextBox);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(887, 170);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Value";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // sampleValueSendButton
            // 
            this.sampleValueSendButton.Location = new System.Drawing.Point(15, 130);
            this.sampleValueSendButton.Name = "sampleValueSendButton";
            this.sampleValueSendButton.Size = new System.Drawing.Size(75, 23);
            this.sampleValueSendButton.TabIndex = 4;
            this.sampleValueSendButton.Text = "Send";
            this.sampleValueSendButton.UseVisualStyleBackColor = true;
            this.sampleValueSendButton.Click += new System.EventHandler(this.sampleValueSendButton_Click);
            // 
            // sampleValueResultTextBox
            // 
            this.sampleValueResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sampleValueResultTextBox.Location = new System.Drawing.Point(15, 91);
            this.sampleValueResultTextBox.Name = "sampleValueResultTextBox";
            this.sampleValueResultTextBox.Size = new System.Drawing.Size(319, 23);
            this.sampleValueResultTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Result";
            // 
            // sampleValueDataItemKeyTextBox
            // 
            this.sampleValueDataItemKeyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sampleValueDataItemKeyTextBox.Location = new System.Drawing.Point(15, 33);
            this.sampleValueDataItemKeyTextBox.Name = "sampleValueDataItemKeyTextBox";
            this.sampleValueDataItemKeyTextBox.Size = new System.Drawing.Size(319, 23);
            this.sampleValueDataItemKeyTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "DataItemKey (ID or Name)";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(887, 170);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "TimeSeries";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataSetDataGridView);
            this.tabPage5.Controls.Add(this.dataSetSendButton);
            this.tabPage5.Controls.Add(this.dataSetDataItemKeyTextBox);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(887, 170);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "DataSet";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataSetDataGridView
            // 
            this.dataSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.keyColumn,
            this.valueColumn,
            this.removedColumn});
            this.dataSetDataGridView.Location = new System.Drawing.Point(363, 11);
            this.dataSetDataGridView.Name = "dataSetDataGridView";
            this.dataSetDataGridView.RowTemplate.Height = 25;
            this.dataSetDataGridView.Size = new System.Drawing.Size(518, 153);
            this.dataSetDataGridView.TabIndex = 16;
            // 
            // keyColumn
            // 
            this.keyColumn.HeaderText = "Key";
            this.keyColumn.Name = "keyColumn";
            this.keyColumn.Width = 150;
            // 
            // valueColumn
            // 
            this.valueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valueColumn.HeaderText = "Value";
            this.valueColumn.Name = "valueColumn";
            // 
            // removedColumn
            // 
            this.removedColumn.HeaderText = "Removed";
            this.removedColumn.Name = "removedColumn";
            // 
            // dataSetSendButton
            // 
            this.dataSetSendButton.Location = new System.Drawing.Point(14, 58);
            this.dataSetSendButton.Name = "dataSetSendButton";
            this.dataSetSendButton.Size = new System.Drawing.Size(75, 23);
            this.dataSetSendButton.TabIndex = 9;
            this.dataSetSendButton.Text = "Send";
            this.dataSetSendButton.UseVisualStyleBackColor = true;
            this.dataSetSendButton.Click += new System.EventHandler(this.dataSetSendButton_Click);
            // 
            // dataSetDataItemKeyTextBox
            // 
            this.dataSetDataItemKeyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataSetDataItemKeyTextBox.Location = new System.Drawing.Point(14, 29);
            this.dataSetDataItemKeyTextBox.Name = "dataSetDataItemKeyTextBox";
            this.dataSetDataItemKeyTextBox.Size = new System.Drawing.Size(319, 23);
            this.dataSetDataItemKeyTextBox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "DataItemKey (ID or Name)";
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 24);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(887, 170);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "Table";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(891, 194);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Event";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.tabPage7.Size = new System.Drawing.Size(891, 194);
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
            this.panel1.Controls.Add(this.connectButton);
            this.panel1.Controls.Add(this.connectionStatusLabel);
            this.panel1.Controls.Add(this.portTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.hostnameTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 33);
            this.panel1.TabIndex = 1;
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
            this.connectionStatusLabel.AutoSize = true;
            this.connectionStatusLabel.Location = new System.Drawing.Point(788, 7);
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(104, 15);
            this.connectionStatusLabel.TabIndex = 4;
            this.connectionStatusLabel.Text = "Connection Status";
            // 
            // portTextBox
            // 
            this.portTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portTextBox.Location = new System.Drawing.Point(503, 5);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(100, 23);
            this.portTextBox.TabIndex = 3;
            this.portTextBox.Text = "7878";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
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
            this.outputListBox.Location = new System.Drawing.Point(16, 279);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.outputListBox.Size = new System.Drawing.Size(895, 154);
            this.outputListBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 446);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "TrakHound MTConnect SHDR Tool";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDataGridView)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage2;
        private Panel panel1;
        private TextBox portTextBox;
        private Label label2;
        private TextBox hostnameTextBox;
        private Label label1;
        private Label connectionStatusLabel;
        private Button sampleValueSendButton;
        private TextBox sampleValueResultTextBox;
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
        private Button dataSetSendButton;
        private TextBox dataSetDataItemKeyTextBox;
        private Label label8;
        private DataGridView dataSetDataGridView;
        private DataGridViewTextBoxColumn keyColumn;
        private DataGridViewTextBoxColumn valueColumn;
        private DataGridViewCheckBoxColumn removedColumn;
    }
}