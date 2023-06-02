namespace LivrariLaDomiciliu
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnFormComenziFacturi = new System.Windows.Forms.Button();
            this.btnFormClienti = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.Color.Turquoise;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("MV Boli", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.Location = new System.Drawing.Point(344, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(571, 83);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Livrari La Domiciliu";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnFormComenziFacturi
            // 
            this.btnFormComenziFacturi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFormComenziFacturi.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnFormComenziFacturi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormComenziFacturi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFormComenziFacturi.Location = new System.Drawing.Point(489, 245);
            this.btnFormComenziFacturi.Name = "btnFormComenziFacturi";
            this.btnFormComenziFacturi.Size = new System.Drawing.Size(268, 52);
            this.btnFormComenziFacturi.TabIndex = 1;
            this.btnFormComenziFacturi.Text = "COMENZI ȘI FACTURI";
            this.btnFormComenziFacturi.UseVisualStyleBackColor = false;
            this.btnFormComenziFacturi.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFormClienti
            // 
            this.btnFormClienti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFormClienti.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnFormClienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormClienti.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFormClienti.Location = new System.Drawing.Point(489, 335);
            this.btnFormClienti.Name = "btnFormClienti";
            this.btnFormClienti.Size = new System.Drawing.Size(268, 52);
            this.btnFormClienti.TabIndex = 2;
            this.btnFormClienti.Text = "CLIENȚI";
            this.btnFormClienti.UseVisualStyleBackColor = false;
            this.btnFormClienti.Click += new System.EventHandler(this.btnFormClienti_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(525, 489);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(195, 42);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Închidere aplicație";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1236, 653);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFormClienti);
            this.Controls.Add(this.btnFormComenziFacturi);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "  Livrari La Domiciliu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnFormComenziFacturi;
        private System.Windows.Forms.Button btnFormClienti;
        private System.Windows.Forms.Button btnExit;
    }
}

