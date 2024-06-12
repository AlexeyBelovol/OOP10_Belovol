namespace lab10
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
            buttonEncryptLucifer = new Button();
            buttonHashN = new Button();
            buttonEncryptRSA = new Button();
            labelResultNHash = new Label();
            labelResultLucifer = new Label();
            labelResultRSA = new Label();
            SuspendLayout();
            // 
            // buttonEncryptLucifer
            // 
            buttonEncryptLucifer.Location = new Point(35, 38);
            buttonEncryptLucifer.Name = "buttonEncryptLucifer";
            buttonEncryptLucifer.Size = new Size(117, 55);
            buttonEncryptLucifer.TabIndex = 0;
            buttonEncryptLucifer.Text = "Lucifer";
            buttonEncryptLucifer.UseVisualStyleBackColor = true;
            buttonEncryptLucifer.Click += buttonEncryptLucifer_Click;
            // 
            // buttonHashN
            // 
            buttonHashN.Location = new Point(35, 128);
            buttonHashN.Name = "buttonHashN";
            buttonHashN.Size = new Size(117, 55);
            buttonHashN.TabIndex = 1;
            buttonHashN.Text = "HashN";
            buttonHashN.UseVisualStyleBackColor = true;
            buttonHashN.Click += buttonHashN_Click;
            // 
            // buttonEncryptRSA
            // 
            buttonEncryptRSA.Location = new Point(35, 219);
            buttonEncryptRSA.Name = "buttonEncryptRSA";
            buttonEncryptRSA.Size = new Size(117, 53);
            buttonEncryptRSA.TabIndex = 2;
            buttonEncryptRSA.Text = "RSA";
            buttonEncryptRSA.UseVisualStyleBackColor = true;
            buttonEncryptRSA.Click += buttonEncryptRSA_Click;
            // 
            // labelResultNHash
            // 
            labelResultNHash.AutoSize = true;
            labelResultNHash.Location = new Point(215, 148);
            labelResultNHash.Name = "labelResultNHash";
            labelResultNHash.Size = new Size(38, 15);
            labelResultNHash.TabIndex = 3;
            labelResultNHash.Text = "label1";
            // 
            // labelResultLucifer
            // 
            labelResultLucifer.AutoSize = true;
            labelResultLucifer.Location = new Point(215, 58);
            labelResultLucifer.Name = "labelResultLucifer";
            labelResultLucifer.Size = new Size(38, 15);
            labelResultLucifer.TabIndex = 4;
            labelResultLucifer.Text = "label2";
            // 
            // labelResultRSA
            // 
            labelResultRSA.AutoSize = true;
            labelResultRSA.Location = new Point(215, 238);
            labelResultRSA.Name = "labelResultRSA";
            labelResultRSA.Size = new Size(38, 15);
            labelResultRSA.TabIndex = 5;
            labelResultRSA.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 315);
            Controls.Add(labelResultRSA);
            Controls.Add(labelResultLucifer);
            Controls.Add(labelResultNHash);
            Controls.Add(buttonEncryptRSA);
            Controls.Add(buttonHashN);
            Controls.Add(buttonEncryptLucifer);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEncryptLucifer;
        private Button buttonHashN;
        private Button buttonEncryptRSA;
        private Label labelResultNHash;
        private Label labelResultLucifer;
        private Label labelResultRSA;
    }
}
