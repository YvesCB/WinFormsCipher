using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCipher
{
    public partial class CipherView : Form
    {
        private readonly CipherController _controller;
        public CipherView()
        {
            InitializeComponent();

            _controller = new CipherController();
            _controller.InitializeDatabase();
        }

        private void LoadData(object sender, EventArgs e)
        {
            var entries = _controller.GetAllEntries();
            cipherTable.DataSource = entries;

            //Hide id colum. User doesn't need it
            cipherTable.Columns["Id"].Visible = false;

            // Set the width of specific columns
            cipherTable.Columns["PlainText"].Width = 300; // Set the width for PlainText column
            cipherTable.Columns["CipherText"].Width = 300; // Set the width for CipherText column
            cipherTable.Columns["Key"].Width = 100; // Set the width for Key column
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            string plainText = plainTextBox.Text;
            string key = keyTextBox.Text;

            Vigenere vigenere = new Vigenere();

            cipherTextBox.Text = vigenere.Encrypt(plainText, key);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cipherText = cipherTextBox.Text;
            string key = keyTextBox.Text;

            Vigenere vigenere = new Vigenere();

            plainTextBox.Text = vigenere.Decrypt(cipherText, key);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //First check if we have data to save at all
            string plainText = plainTextBox.Text;
            string cipherText = cipherTextBox.Text;
            string key = keyTextBox.Text;

            if (plainText == "" || cipherText == "")
            {
                MessageBox.Show(
                    "No text in fields 'Plain Text' or 'Cipher Text'. Both need to be filled for a valid entry",
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                _controller.InsertEntry(DateTime.Now, plainText, cipherText, key);
                LoadData(null, null);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (cipherTable.SelectedRows.Count > 0)
            {
                var selectedRow = cipherTable.SelectedRows[0];
                var entryId = (int)selectedRow.Cells["Id"].Value;

                // Delete the entry from the database
                _controller.DeleteEntryById(entryId);

                // Refresh the DataGridView
                LoadData(null, null);
            }
            else
            {
                MessageBox.Show("No row selected. Please select a row to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cell_doubleClick(object sender, EventArgs e)
        {
            if (cipherTable.SelectedRows.Count > 0)
            {
                var selectedRow = cipherTable.SelectedRows[0];
                plainTextBox.Text = selectedRow.Cells["PlainText"].Value.ToString();
                cipherTextBox.Text = selectedRow.Cells["CipherText"].Value.ToString();
                keyTextBox.Text = selectedRow.Cells["Key"].Value.ToString();
            }
        }
    }
}
