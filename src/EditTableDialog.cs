using MTConnect.Shdr;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MTConnect.Applications.SHDR_Tool
{
    public partial class EditTableDialog : Form
    {
        private string _entryKey;


        public EditTableDialog(string entryKey)
        {
            InitializeComponent();
            _entryKey = entryKey;

            Text = $"Edit {_entryKey} Cells";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            cellsDataGridView.Rows.Clear();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var cells = new List<ShdrTableCell>();
            if (cellsDataGridView.Rows.Count > 0)
            {
                for (var i = 0; i < cellsDataGridView.Rows.Count; i++)
                {
                    var cellKey = cellsDataGridView[0, i].Value?.ToString();
                    var cellValue = cellsDataGridView[1, i].Value?.ToString();

                    if (!string.IsNullOrEmpty(cellKey) && !string.IsNullOrEmpty(cellValue))
                    {
                        cells.Add(new ShdrTableCell(cellKey, cellValue));
                    }
                }
            }

            Program.MainForm.UpdateTableEntry(_entryKey, cells);

            Close();
        }
    }
}
