namespace LivrariLaDomiciliu
{
    partial class GenerateInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateInvoice));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDeliveryPersonName = new System.Windows.Forms.TextBox();
            this.txtDeliveryPrice = new System.Windows.Forms.TextBox();
            this.comboBoxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnCancelGeneration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numele livratorului:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pretul livrarii:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Metoda de plata:";
            // 
            // txtDeliveryPersonName
            // 
            this.txtDeliveryPersonName.Location = new System.Drawing.Point(236, 56);
            this.txtDeliveryPersonName.Name = "txtDeliveryPersonName";
            this.txtDeliveryPersonName.Size = new System.Drawing.Size(192, 22);
            this.txtDeliveryPersonName.TabIndex = 3;
            this.txtDeliveryPersonName.TextChanged += new System.EventHandler(this.txtDeliveryPersonName_TextChanged);
            // 
            // txtDeliveryPrice
            // 
            this.txtDeliveryPrice.Location = new System.Drawing.Point(236, 97);
            this.txtDeliveryPrice.Name = "txtDeliveryPrice";
            this.txtDeliveryPrice.Size = new System.Drawing.Size(192, 22);
            this.txtDeliveryPrice.TabIndex = 4;
            // 
            // comboBoxPaymentMethod
            // 
            this.comboBoxPaymentMethod.FormattingEnabled = true;
            this.comboBoxPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Card, online",
            "Card, la livrare"});
            this.comboBoxPaymentMethod.Location = new System.Drawing.Point(236, 141);
            this.comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            this.comboBoxPaymentMethod.Size = new System.Drawing.Size(192, 24);
            this.comboBoxPaymentMethod.TabIndex = 5;
            // 
            // btnGenerate
            // 
            this.btnGenerate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGenerate.Location = new System.Drawing.Point(321, 259);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(107, 36);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Genereaza";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCancelGeneration
            // 
            this.btnCancelGeneration.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelGeneration.Location = new System.Drawing.Point(61, 259);
            this.btnCancelGeneration.Name = "btnCancelGeneration";
            this.btnCancelGeneration.Size = new System.Drawing.Size(112, 36);
            this.btnCancelGeneration.TabIndex = 7;
            this.btnCancelGeneration.Text = "Anuleaza";
            this.btnCancelGeneration.UseVisualStyleBackColor = true;
            this.btnCancelGeneration.Click += new System.EventHandler(this.btnCancelGeneration_Click);
            // 
            // GenerateInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 360);
            this.Controls.Add(this.btnCancelGeneration);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.comboBoxPaymentMethod);
            this.Controls.Add(this.txtDeliveryPrice);
            this.Controls.Add(this.txtDeliveryPersonName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GenerateInvoice";
            this.Text = "Generare Factura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDeliveryPersonName;
        private System.Windows.Forms.TextBox txtDeliveryPrice;
        private System.Windows.Forms.ComboBox comboBoxPaymentMethod;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnCancelGeneration;
    }
}