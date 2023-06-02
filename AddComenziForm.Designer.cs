namespace LivrariLaDomiciliu
{
    partial class AddComenziForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddComenziForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.lblIsFragile = new System.Windows.Forms.Label();
            this.lblSenderName = new System.Windows.Forms.Label();
            this.lblReceiverName = new System.Windows.Forms.Label();
            this.lblDestinationAdress = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtDeliveredItem = new System.Windows.Forms.TextBox();
            this.txtDestinationAddress = new System.Windows.Forms.TextBox();
            this.txtReceiverName = new System.Windows.Forms.TextBox();
            this.txtSenderName = new System.Windows.Forms.TextBox();
            this.checkIsFragile = new System.Windows.Forms.CheckBox();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Greutate (kg):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Obiect livrat:";
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Location = new System.Drawing.Point(47, 244);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDeliveryDate.Size = new System.Drawing.Size(102, 16);
            this.lblDeliveryDate.TabIndex = 19;
            this.lblDeliveryDate.Tag = "Livrare pana la: ";
            this.lblDeliveryDate.Text = "Livrare pana la: ";
            // 
            // lblIsFragile
            // 
            this.lblIsFragile.AutoSize = true;
            this.lblIsFragile.Location = new System.Drawing.Point(47, 219);
            this.lblIsFragile.Name = "lblIsFragile";
            this.lblIsFragile.Size = new System.Drawing.Size(47, 16);
            this.lblIsFragile.TabIndex = 18;
            this.lblIsFragile.Tag = "Fragil: ";
            this.lblIsFragile.Text = "Fragil: ";
            // 
            // lblSenderName
            // 
            this.lblSenderName.AutoSize = true;
            this.lblSenderName.Location = new System.Drawing.Point(47, 189);
            this.lblSenderName.Name = "lblSenderName";
            this.lblSenderName.Size = new System.Drawing.Size(108, 16);
            this.lblSenderName.TabIndex = 17;
            this.lblSenderName.Tag = "Nume expeditor: ";
            this.lblSenderName.Text = "Nume expeditor: ";
            // 
            // lblReceiverName
            // 
            this.lblReceiverName.AutoSize = true;
            this.lblReceiverName.Location = new System.Drawing.Point(47, 161);
            this.lblReceiverName.Name = "lblReceiverName";
            this.lblReceiverName.Size = new System.Drawing.Size(111, 16);
            this.lblReceiverName.TabIndex = 16;
            this.lblReceiverName.Tag = "Nume destinatar: ";
            this.lblReceiverName.Text = "Nume destinatar: ";
            // 
            // lblDestinationAdress
            // 
            this.lblDestinationAdress.AutoSize = true;
            this.lblDestinationAdress.Location = new System.Drawing.Point(47, 133);
            this.lblDestinationAdress.Name = "lblDestinationAdress";
            this.lblDestinationAdress.Size = new System.Drawing.Size(119, 16);
            this.lblDestinationAdress.TabIndex = 15;
            this.lblDestinationAdress.Tag = "Adresa destinatar: ";
            this.lblDestinationAdress.Text = "Adresa destinatar: ";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(182, 43);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(187, 22);
            this.txtID.TabIndex = 20;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(182, 71);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(187, 22);
            this.txtWeight.TabIndex = 21;
            // 
            // txtDeliveredItem
            // 
            this.txtDeliveredItem.Location = new System.Drawing.Point(182, 99);
            this.txtDeliveredItem.Name = "txtDeliveredItem";
            this.txtDeliveredItem.Size = new System.Drawing.Size(187, 22);
            this.txtDeliveredItem.TabIndex = 22;
            // 
            // txtDestinationAddress
            // 
            this.txtDestinationAddress.Location = new System.Drawing.Point(182, 127);
            this.txtDestinationAddress.Name = "txtDestinationAddress";
            this.txtDestinationAddress.Size = new System.Drawing.Size(187, 22);
            this.txtDestinationAddress.TabIndex = 23;
            // 
            // txtReceiverName
            // 
            this.txtReceiverName.Location = new System.Drawing.Point(182, 155);
            this.txtReceiverName.Name = "txtReceiverName";
            this.txtReceiverName.Size = new System.Drawing.Size(187, 22);
            this.txtReceiverName.TabIndex = 24;
            // 
            // txtSenderName
            // 
            this.txtSenderName.Location = new System.Drawing.Point(182, 183);
            this.txtSenderName.Name = "txtSenderName";
            this.txtSenderName.Size = new System.Drawing.Size(187, 22);
            this.txtSenderName.TabIndex = 25;
            // 
            // checkIsFragile
            // 
            this.checkIsFragile.AutoSize = true;
            this.checkIsFragile.Location = new System.Drawing.Point(182, 219);
            this.checkIsFragile.Name = "checkIsFragile";
            this.checkIsFragile.Size = new System.Drawing.Size(18, 17);
            this.checkIsFragile.TabIndex = 26;
            this.checkIsFragile.UseVisualStyleBackColor = true;
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.Location = new System.Drawing.Point(182, 244);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDeliveryDate.TabIndex = 27;
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(292, 443);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 39);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Adauga";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(50, 443);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 39);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Anuleaza";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEdit.Location = new System.Drawing.Point(173, 443);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 39);
            this.btnEdit.TabIndex = 30;
            this.btnEdit.Text = "Editeaza";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // AddComenziForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 516);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpDeliveryDate);
            this.Controls.Add(this.checkIsFragile);
            this.Controls.Add(this.txtSenderName);
            this.Controls.Add(this.txtReceiverName);
            this.Controls.Add(this.txtDestinationAddress);
            this.Controls.Add(this.txtDeliveredItem);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblDeliveryDate);
            this.Controls.Add(this.lblIsFragile);
            this.Controls.Add(this.lblSenderName);
            this.Controls.Add(this.lblReceiverName);
            this.Controls.Add(this.lblDestinationAdress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddComenziForm";
            this.Text = "Adauga sau Editeaza Comanda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.Label lblIsFragile;
        private System.Windows.Forms.Label lblSenderName;
        private System.Windows.Forms.Label lblReceiverName;
        private System.Windows.Forms.Label lblDestinationAdress;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtDeliveredItem;
        private System.Windows.Forms.TextBox txtDestinationAddress;
        private System.Windows.Forms.TextBox txtReceiverName;
        private System.Windows.Forms.TextBox txtSenderName;
        private System.Windows.Forms.CheckBox checkIsFragile;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
    }
}