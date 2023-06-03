namespace LivrariLaDomiciliu
{
    partial class FormComenziFacturi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComenziFacturi));
            this.lbFinished = new System.Windows.Forms.ListBox();
            this.lbWaiting = new System.Windows.Forms.ListBox();
            this.labelComenziFinalizate = new System.Windows.Forms.Label();
            this.labelComenziInPrelucrare = new System.Windows.Forms.Label();
            this.lblInformatii = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblDeliveredItem = new System.Windows.Forms.Label();
            this.lblDestinationAdress = new System.Windows.Forms.Label();
            this.lblReceiverName = new System.Windows.Forms.Label();
            this.lblSenderName = new System.Windows.Forms.Label();
            this.lblIsFragile = new System.Windows.Forms.Label();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.btAddFinished = new System.Windows.Forms.Button();
            this.btEditFinished = new System.Windows.Forms.Button();
            this.btRemoveFinished = new System.Windows.Forms.Button();
            this.btAddWaiting = new System.Windows.Forms.Button();
            this.btEditWaiting = new System.Windows.Forms.Button();
            this.btRemoveWaiting = new System.Windows.Forms.Button();
            this.btnUnselect = new System.Windows.Forms.Button();
            this.lblFacturaHeader = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // lbFinished
            // 
            this.lbFinished.AllowDrop = true;
            this.lbFinished.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFinished.BackColor = System.Drawing.Color.LawnGreen;
            this.lbFinished.FormattingEnabled = true;
            this.lbFinished.ItemHeight = 16;
            this.lbFinished.Location = new System.Drawing.Point(32, 98);
            this.lbFinished.Name = "lbFinished";
            this.lbFinished.Size = new System.Drawing.Size(210, 132);
            this.lbFinished.TabIndex = 0;
            // 
            // lbWaiting
            // 
            this.lbWaiting.AllowDrop = true;
            this.lbWaiting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbWaiting.BackColor = System.Drawing.Color.OrangeRed;
            this.lbWaiting.FormattingEnabled = true;
            this.lbWaiting.ItemHeight = 16;
            this.lbWaiting.Location = new System.Drawing.Point(347, 98);
            this.lbWaiting.Name = "lbWaiting";
            this.lbWaiting.Size = new System.Drawing.Size(213, 132);
            this.lbWaiting.TabIndex = 0;
            this.lbWaiting.SelectedIndexChanged += new System.EventHandler(this.lbWaiting_SelectedIndexChanged);
            // 
            // labelComenziFinalizate
            // 
            this.labelComenziFinalizate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelComenziFinalizate.AutoSize = true;
            this.labelComenziFinalizate.BackColor = System.Drawing.Color.Transparent;
            this.labelComenziFinalizate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComenziFinalizate.Location = new System.Drawing.Point(28, 73);
            this.labelComenziFinalizate.Name = "labelComenziFinalizate";
            this.labelComenziFinalizate.Size = new System.Drawing.Size(160, 22);
            this.labelComenziFinalizate.TabIndex = 1;
            this.labelComenziFinalizate.Text = "Comenzi Finalizate";
            // 
            // labelComenziInPrelucrare
            // 
            this.labelComenziInPrelucrare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelComenziInPrelucrare.AutoSize = true;
            this.labelComenziInPrelucrare.BackColor = System.Drawing.Color.Transparent;
            this.labelComenziInPrelucrare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComenziInPrelucrare.Location = new System.Drawing.Point(357, 73);
            this.labelComenziInPrelucrare.Name = "labelComenziInPrelucrare";
            this.labelComenziInPrelucrare.Size = new System.Drawing.Size(186, 22);
            this.labelComenziInPrelucrare.TabIndex = 2;
            this.labelComenziInPrelucrare.Text = "Comenzi In Prelucrare";
            // 
            // lblInformatii
            // 
            this.lblInformatii.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInformatii.AutoSize = true;
            this.lblInformatii.BackColor = System.Drawing.Color.Transparent;
            this.lblInformatii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformatii.Location = new System.Drawing.Point(31, 470);
            this.lblInformatii.Name = "lblInformatii";
            this.lblInformatii.Size = new System.Drawing.Size(247, 25);
            this.lblInformatii.TabIndex = 3;
            this.lblInformatii.Text = "Informatii despre comanda:";
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(33, 518);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 16);
            this.lblID.TabIndex = 4;
            this.lblID.Tag = "ID: ";
            this.lblID.Text = "ID: ";
            // 
            // lblWeight
            // 
            this.lblWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(33, 544);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(90, 16);
            this.lblWeight.TabIndex = 5;
            this.lblWeight.Tag = "Greutate (kg): ";
            this.lblWeight.Text = "Greutate (kg): ";
            // 
            // lblDeliveredItem
            // 
            this.lblDeliveredItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDeliveredItem.AutoSize = true;
            this.lblDeliveredItem.Location = new System.Drawing.Point(33, 572);
            this.lblDeliveredItem.Name = "lblDeliveredItem";
            this.lblDeliveredItem.Size = new System.Drawing.Size(83, 16);
            this.lblDeliveredItem.TabIndex = 6;
            this.lblDeliveredItem.Tag = "Obiect livrat: ";
            this.lblDeliveredItem.Text = "Obiect livrat: ";
            // 
            // lblDestinationAdress
            // 
            this.lblDestinationAdress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDestinationAdress.AutoSize = true;
            this.lblDestinationAdress.Location = new System.Drawing.Point(33, 603);
            this.lblDestinationAdress.Name = "lblDestinationAdress";
            this.lblDestinationAdress.Size = new System.Drawing.Size(119, 16);
            this.lblDestinationAdress.TabIndex = 7;
            this.lblDestinationAdress.Tag = "Adresa destinatar: ";
            this.lblDestinationAdress.Text = "Adresa destinatar: ";
            // 
            // lblReceiverName
            // 
            this.lblReceiverName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReceiverName.AutoSize = true;
            this.lblReceiverName.Location = new System.Drawing.Point(344, 518);
            this.lblReceiverName.Name = "lblReceiverName";
            this.lblReceiverName.Size = new System.Drawing.Size(111, 16);
            this.lblReceiverName.TabIndex = 8;
            this.lblReceiverName.Tag = "Nume destinatar: ";
            this.lblReceiverName.Text = "Nume destinatar: ";
            // 
            // lblSenderName
            // 
            this.lblSenderName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSenderName.AutoSize = true;
            this.lblSenderName.Location = new System.Drawing.Point(344, 544);
            this.lblSenderName.Name = "lblSenderName";
            this.lblSenderName.Size = new System.Drawing.Size(108, 16);
            this.lblSenderName.TabIndex = 9;
            this.lblSenderName.Tag = "Nume expeditor: ";
            this.lblSenderName.Text = "Nume expeditor: ";
            // 
            // lblIsFragile
            // 
            this.lblIsFragile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIsFragile.AutoSize = true;
            this.lblIsFragile.Location = new System.Drawing.Point(344, 572);
            this.lblIsFragile.Name = "lblIsFragile";
            this.lblIsFragile.Size = new System.Drawing.Size(47, 16);
            this.lblIsFragile.TabIndex = 10;
            this.lblIsFragile.Tag = "Fragil: ";
            this.lblIsFragile.Text = "Fragil: ";
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Location = new System.Drawing.Point(344, 603);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDeliveryDate.Size = new System.Drawing.Size(102, 16);
            this.lblDeliveryDate.TabIndex = 11;
            this.lblDeliveryDate.Tag = "Livrare pana la: ";
            this.lblDeliveryDate.Text = "Livrare pana la: ";
            // 
            // btAddFinished
            // 
            this.btAddFinished.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAddFinished.Location = new System.Drawing.Point(32, 271);
            this.btAddFinished.Name = "btAddFinished";
            this.btAddFinished.Size = new System.Drawing.Size(210, 28);
            this.btAddFinished.TabIndex = 12;
            this.btAddFinished.Text = "Adauga comanda finalizata";
            this.btAddFinished.UseVisualStyleBackColor = true;
            this.btAddFinished.Click += new System.EventHandler(this.btAddFinished_Click);
            // 
            // btEditFinished
            // 
            this.btEditFinished.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btEditFinished.Location = new System.Drawing.Point(32, 314);
            this.btEditFinished.Name = "btEditFinished";
            this.btEditFinished.Size = new System.Drawing.Size(210, 28);
            this.btEditFinished.TabIndex = 13;
            this.btEditFinished.Text = "Editeaza comanda finalizata";
            this.btEditFinished.UseVisualStyleBackColor = true;
            this.btEditFinished.Click += new System.EventHandler(this.btEditFinished_Click);
            // 
            // btRemoveFinished
            // 
            this.btRemoveFinished.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btRemoveFinished.Location = new System.Drawing.Point(32, 359);
            this.btRemoveFinished.Name = "btRemoveFinished";
            this.btRemoveFinished.Size = new System.Drawing.Size(210, 28);
            this.btRemoveFinished.TabIndex = 14;
            this.btRemoveFinished.Text = "Stergere comanda finalizata";
            this.btRemoveFinished.UseVisualStyleBackColor = true;
            this.btRemoveFinished.Click += new System.EventHandler(this.btRemoveFinished_Click);
            // 
            // btAddWaiting
            // 
            this.btAddWaiting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAddWaiting.Location = new System.Drawing.Point(347, 271);
            this.btAddWaiting.Name = "btAddWaiting";
            this.btAddWaiting.Size = new System.Drawing.Size(213, 28);
            this.btAddWaiting.TabIndex = 15;
            this.btAddWaiting.Text = "Adauga comanda nefinalizata";
            this.btAddWaiting.UseVisualStyleBackColor = true;
            this.btAddWaiting.Click += new System.EventHandler(this.btAddWaiting_Click);
            // 
            // btEditWaiting
            // 
            this.btEditWaiting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btEditWaiting.Location = new System.Drawing.Point(347, 314);
            this.btEditWaiting.Name = "btEditWaiting";
            this.btEditWaiting.Size = new System.Drawing.Size(213, 28);
            this.btEditWaiting.TabIndex = 16;
            this.btEditWaiting.Text = "Editeaza comanda nefinalizata";
            this.btEditWaiting.UseVisualStyleBackColor = true;
            this.btEditWaiting.Click += new System.EventHandler(this.btEditWaiting_Click);
            // 
            // btRemoveWaiting
            // 
            this.btRemoveWaiting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btRemoveWaiting.Location = new System.Drawing.Point(347, 359);
            this.btRemoveWaiting.Name = "btRemoveWaiting";
            this.btRemoveWaiting.Size = new System.Drawing.Size(213, 28);
            this.btRemoveWaiting.TabIndex = 17;
            this.btRemoveWaiting.Text = "Sterge comanda nefinalizata";
            this.btRemoveWaiting.UseVisualStyleBackColor = true;
            this.btRemoveWaiting.Click += new System.EventHandler(this.btRemoveWaiting_Click);
            // 
            // btnUnselect
            // 
            this.btnUnselect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUnselect.Location = new System.Drawing.Point(32, 438);
            this.btnUnselect.Name = "btnUnselect";
            this.btnUnselect.Size = new System.Drawing.Size(183, 23);
            this.btnUnselect.TabIndex = 18;
            this.btnUnselect.Text = "Deselecteaza Comanda";
            this.btnUnselect.UseVisualStyleBackColor = true;
            this.btnUnselect.Click += new System.EventHandler(this.btnUnselect_Click);
            // 
            // lblFacturaHeader
            // 
            this.lblFacturaHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFacturaHeader.AutoSize = true;
            this.lblFacturaHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblFacturaHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturaHeader.Location = new System.Drawing.Point(856, 73);
            this.lblFacturaHeader.Name = "lblFacturaHeader";
            this.lblFacturaHeader.Size = new System.Drawing.Size(71, 22);
            this.lblFacturaHeader.TabIndex = 19;
            this.lblFacturaHeader.Text = "Factură";
            // 
            // txtFactura
            // 
            this.txtFactura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFactura.Location = new System.Drawing.Point(736, 99);
            this.txtFactura.Multiline = true;
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.ReadOnly = true;
            this.txtFactura.Size = new System.Drawing.Size(323, 396);
            this.txtFactura.TabIndex = 20;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerate.Location = new System.Drawing.Point(815, 527);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(163, 23);
            this.btnGenerate.TabIndex = 21;
            this.btnGenerate.Text = "Generare Factura";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrint.Location = new System.Drawing.Point(815, 565);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(163, 23);
            this.btnPrint.TabIndex = 22;
            this.btnPrint.Text = "Printeaza Factura";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // FormComenziFacturi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1126, 668);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.lblFacturaHeader);
            this.Controls.Add(this.btnUnselect);
            this.Controls.Add(this.btRemoveWaiting);
            this.Controls.Add(this.btEditWaiting);
            this.Controls.Add(this.btAddWaiting);
            this.Controls.Add(this.btRemoveFinished);
            this.Controls.Add(this.btEditFinished);
            this.Controls.Add(this.btAddFinished);
            this.Controls.Add(this.lblDeliveryDate);
            this.Controls.Add(this.lblIsFragile);
            this.Controls.Add(this.lblSenderName);
            this.Controls.Add(this.lblReceiverName);
            this.Controls.Add(this.lblDestinationAdress);
            this.Controls.Add(this.lblDeliveredItem);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblInformatii);
            this.Controls.Add(this.labelComenziInPrelucrare);
            this.Controls.Add(this.labelComenziFinalizate);
            this.Controls.Add(this.lbWaiting);
            this.Controls.Add(this.lbFinished);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormComenziFacturi";
            this.Text = "Comenzi si Facturi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbFinished;
        private System.Windows.Forms.ListBox lbWaiting;
        private System.Windows.Forms.Label labelComenziFinalizate;
        private System.Windows.Forms.Label labelComenziInPrelucrare;
        private System.Windows.Forms.Label lblInformatii;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblDeliveredItem;
        private System.Windows.Forms.Label lblDestinationAdress;
        private System.Windows.Forms.Label lblReceiverName;
        private System.Windows.Forms.Label lblSenderName;
        private System.Windows.Forms.Label lblIsFragile;
        private System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.Button btAddFinished;
        private System.Windows.Forms.Button btEditFinished;
        private System.Windows.Forms.Button btRemoveFinished;
        private System.Windows.Forms.Button btAddWaiting;
        private System.Windows.Forms.Button btEditWaiting;
        private System.Windows.Forms.Button btRemoveWaiting;
        private System.Windows.Forms.Button btnUnselect;
        private System.Windows.Forms.Label lblFacturaHeader;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}