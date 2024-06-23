namespace WinFormsCipher
{
    partial class CipherView
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
            plainTextBox = new System.Windows.Forms.TextBox();
            encryptButton = new System.Windows.Forms.Button();
            decryptButton = new System.Windows.Forms.Button();
            keyTextBox = new System.Windows.Forms.TextBox();
            plainTextLabel = new System.Windows.Forms.Label();
            encryptionKeyLabel = new System.Windows.Forms.Label();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            cipherTable = new System.Windows.Forms.DataGridView();
            cipherTextBox = new System.Windows.Forms.TextBox();
            cipherTextLabel = new System.Windows.Forms.Label();
            saveButton = new System.Windows.Forms.Button();
            deleteButton = new System.Windows.Forms.Button();
            doubleClickHint = new System.Windows.Forms.Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cipherTable).BeginInit();
            SuspendLayout();
            // 
            // plainTextBox
            // 
            plainTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(plainTextBox, 2);
            plainTextBox.Location = new System.Drawing.Point(4, 362);
            plainTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            plainTextBox.Multiline = true;
            plainTextBox.Name = "plainTextBox";
            plainTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            plainTextBox.Size = new System.Drawing.Size(439, 230);
            plainTextBox.TabIndex = 0;
            // 
            // encryptButton
            // 
            encryptButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            encryptButton.Location = new System.Drawing.Point(4, 682);
            encryptButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            encryptButton.Name = "encryptButton";
            encryptButton.Size = new System.Drawing.Size(204, 24);
            encryptButton.TabIndex = 1;
            encryptButton.Text = "Encrypt";
            encryptButton.UseVisualStyleBackColor = true;
            encryptButton.Click += encryptButton_Click;
            // 
            // decryptButton
            // 
            decryptButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            decryptButton.Location = new System.Drawing.Point(216, 682);
            decryptButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            decryptButton.Name = "decryptButton";
            decryptButton.Size = new System.Drawing.Size(227, 24);
            decryptButton.TabIndex = 2;
            decryptButton.Text = "Decrypt";
            decryptButton.UseVisualStyleBackColor = true;
            decryptButton.Click += decryptButton_Click;
            // 
            // keyTextBox
            // 
            tableLayoutPanel1.SetColumnSpan(keyTextBox, 2);
            keyTextBox.Location = new System.Drawing.Point(4, 623);
            keyTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            keyTextBox.Multiline = true;
            keyTextBox.Name = "keyTextBox";
            keyTextBox.Size = new System.Drawing.Size(439, 51);
            keyTextBox.TabIndex = 4;
            // 
            // plainTextLabel
            // 
            plainTextLabel.AutoSize = true;
            plainTextLabel.Location = new System.Drawing.Point(4, 337);
            plainTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            plainTextLabel.Name = "plainTextLabel";
            plainTextLabel.Size = new System.Drawing.Size(57, 15);
            plainTextLabel.TabIndex = 5;
            plainTextLabel.Text = "Plain Text";
            // 
            // encryptionKeyLabel
            // 
            encryptionKeyLabel.AutoSize = true;
            encryptionKeyLabel.Location = new System.Drawing.Point(4, 600);
            encryptionKeyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            encryptionKeyLabel.Name = "encryptionKeyLabel";
            encryptionKeyLabel.Size = new System.Drawing.Size(86, 15);
            encryptionKeyLabel.TabIndex = 6;
            encryptionKeyLabel.Text = "Encryption Key";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.53247F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.46753F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 212F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            tableLayoutPanel1.Controls.Add(keyTextBox, 0, 5);
            tableLayoutPanel1.Controls.Add(encryptionKeyLabel, 0, 4);
            tableLayoutPanel1.Controls.Add(plainTextBox, 0, 3);
            tableLayoutPanel1.Controls.Add(plainTextLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(encryptButton, 0, 6);
            tableLayoutPanel1.Controls.Add(cipherTable, 0, 0);
            tableLayoutPanel1.Controls.Add(cipherTextBox, 2, 3);
            tableLayoutPanel1.Controls.Add(cipherTextLabel, 2, 2);
            tableLayoutPanel1.Controls.Add(decryptButton, 1, 6);
            tableLayoutPanel1.Controls.Add(saveButton, 2, 6);
            tableLayoutPanel1.Controls.Add(deleteButton, 3, 6);
            tableLayoutPanel1.Controls.Add(doubleClickHint, 0, 1);
            tableLayoutPanel1.Location = new System.Drawing.Point(36, 27);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 303F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.36364F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.63636F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 241F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            tableLayoutPanel1.Size = new System.Drawing.Size(880, 726);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // cipherTable
            // 
            cipherTable.AllowUserToAddRows = false;
            cipherTable.AllowUserToDeleteRows = false;
            cipherTable.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cipherTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(cipherTable, 4);
            cipherTable.Location = new System.Drawing.Point(4, 3);
            cipherTable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cipherTable.MultiSelect = false;
            cipherTable.Name = "cipherTable";
            cipherTable.ReadOnly = true;
            cipherTable.Size = new System.Drawing.Size(872, 297);
            cipherTable.TabIndex = 0;
            cipherTable.CellDoubleClick += cell_doubleClick;
            // 
            // cipherTextBox
            // 
            cipherTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(cipherTextBox, 2);
            cipherTextBox.Location = new System.Drawing.Point(451, 362);
            cipherTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cipherTextBox.Multiline = true;
            cipherTextBox.Name = "cipherTextBox";
            cipherTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            cipherTextBox.Size = new System.Drawing.Size(425, 230);
            cipherTextBox.TabIndex = 7;
            // 
            // cipherTextLabel
            // 
            cipherTextLabel.AutoSize = true;
            cipherTextLabel.Location = new System.Drawing.Point(451, 337);
            cipherTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cipherTextLabel.Name = "cipherTextLabel";
            cipherTextLabel.Size = new System.Drawing.Size(66, 15);
            cipherTextLabel.TabIndex = 8;
            cipherTextLabel.Text = "Cipher Text";
            // 
            // saveButton
            // 
            saveButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            saveButton.Location = new System.Drawing.Point(451, 682);
            saveButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            saveButton.Name = "saveButton";
            saveButton.Size = new System.Drawing.Size(204, 24);
            saveButton.TabIndex = 9;
            saveButton.Text = "Save Entry";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            deleteButton.Location = new System.Drawing.Point(663, 682);
            deleteButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new System.Drawing.Size(213, 24);
            deleteButton.TabIndex = 10;
            deleteButton.Text = "Delete Entry";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // doubleClickHint
            // 
            doubleClickHint.AutoSize = true;
            doubleClickHint.Location = new System.Drawing.Point(3, 303);
            doubleClickHint.Name = "doubleClickHint";
            doubleClickHint.Size = new System.Drawing.Size(177, 15);
            doubleClickHint.TabIndex = 11;
            doubleClickHint.Text = "Double click row to retrieve data";
            // 
            // CipherView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(955, 785);
            Controls.Add(tableLayoutPanel1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "CipherView";
            Text = "Cipher";
            Load += LoadData;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cipherTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox plainTextBox;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label plainTextLabel;
        private System.Windows.Forms.Label encryptionKeyLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView cipherTable;
        private System.Windows.Forms.TextBox cipherTextBox;
        private System.Windows.Forms.Label cipherTextLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label doubleClickHint;
    }
}

