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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            String plainText = plainInputTextBox.Text;
            String key = keyTextBox.Text; 

            Vigenere vigenere = new Vigenere();

            chipherTextBox.Text = vigenere.Encrypt(plainText, key);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cipherText = chipherTextBox.Text;
            String key = keyTextBox.Text;

            Vigenere vigenere = new Vigenere();

            plainInputTextBox.Text = vigenere.Decrypt(cipherText, key);
        }

    }
}
