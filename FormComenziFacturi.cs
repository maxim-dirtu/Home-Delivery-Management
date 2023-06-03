using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivrariLaDomiciliu
{
    public partial class FormComenziFacturi : Form
    {
        public FormComenziFacturi()
        {
            InitializeComponent();
            //lbWaiting.AllowDrop = true;
            //lbFinished.AllowDrop = true;

            Comenzi comanda1 = new Comenzi(1, 0.2f,"PowerBank", "Str. Aleea Zarandului 6", "Maxim Dirtu", "AnonymousSender", false, DateTime.Now.AddDays(3));
            Comenzi comanda2 = new Comenzi(2, 2.5f,"A fish acvarium", "Str. Frumoasa 9", "AnonymousReceiver", "A good guy", true, DateTime.Now.AddDays(5));
            Comenzi comanda3 = new Comenzi(3, 1, "Ball inflanting pump ", "Str. Aleea Zarandului 6", "Maxim Dirtu", "eMAG", false, DateTime.Now.AddDays(2));

            lbFinished.Items.Add(comanda1);
            lbWaiting.Items.Add(comanda2);
            lbWaiting.Items.Add(comanda3);

        }

        private void lbFinished_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbWaiting.SelectedIndexChanged -= lbWaiting_SelectedIndexChanged; // Unsubscribe from lbWaiting event
            lbWaiting.SelectedIndex = -1; // Deselect lbWaiting ListBox
            lbWaiting.SelectedIndexChanged += lbWaiting_SelectedIndexChanged; // Subscribe to lbWaiting event again


            Comenzi comanda = (Comenzi)lbFinished.SelectedItem;
            if (lbFinished.SelectedIndex != -1)
            {
                lblID.Text = lblID.Tag + comanda.id.ToString();
                lblWeight.Text = lblWeight.Tag + comanda.weight.ToString();
                lblDeliveredItem.Text = lblDeliveredItem.Tag + comanda.deliveredItem.ToString();
                lblDestinationAdress.Text = lblDestinationAdress.Tag + comanda.destinationAdress.ToString();
                lblReceiverName.Text = lblReceiverName.Tag + comanda.receiverName.ToString();
                lblSenderName.Text = lblSenderName.Tag + comanda.senderName.ToString();
                lblIsFragile.Text = lblIsFragile.Tag + comanda.isFragile.ToString();
                lblDeliveryDate.Text = lblDeliveryDate.Tag + comanda.deliveryDate.ToString();
            }
         
        }

        private void lbWaiting_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbFinished.SelectedIndexChanged -= lbFinished_SelectedIndexChanged; // Unsubscribe from lbFinished event
            lbFinished.SelectedIndex = -1; // Deselect lbFinished ListBox
            lbFinished.SelectedIndexChanged += lbFinished_SelectedIndexChanged; // Subscribe to lbFinished event again

            Comenzi comanda = (Comenzi)lbWaiting.SelectedItem;

            if (lbWaiting.SelectedIndex != -1)
            {
                lblID.Text = lblID.Tag + comanda.id.ToString();
                lblWeight.Text = lblWeight.Tag + comanda.weight.ToString();
                lblDeliveredItem.Text = lblDeliveredItem.Tag + comanda.deliveredItem.ToString();
                lblDestinationAdress.Text = lblDestinationAdress.Tag + comanda.destinationAdress.ToString();
                lblReceiverName.Text = lblReceiverName.Tag + comanda.receiverName.ToString();
                lblSenderName.Text = lblSenderName.Tag + comanda.senderName.ToString();
                lblIsFragile.Text = lblIsFragile.Tag + comanda.isFragile.ToString();
                lblDeliveryDate.Text = lblDeliveryDate.Tag + comanda.deliveryDate.ToString();
            }

        }

        private void btnUnselect_Click(object sender, EventArgs e)
        {
            lblID.Text = (string)lblID.Tag;
            lblWeight.Text = (string)lblWeight.Tag ;
            lblDeliveredItem.Text = lblDeliveredItem.Tag.ToString() ;
            lblDestinationAdress.Text = lblDestinationAdress.Tag.ToString();
            lblReceiverName.Text = lblReceiverName.Tag.ToString() ;
            lblSenderName.Text = lblSenderName.Tag.ToString();
            lblIsFragile.Text = lblIsFragile.Tag.ToString();
            lblDeliveryDate.Text = lblDeliveryDate.Tag.ToString();
            lbFinished.SelectedItems.Remove(lbFinished.SelectedItem);
            lbWaiting.SelectedItems.Remove(lbWaiting.SelectedItem);
        }

        private void btAddWaiting_Click(object sender, EventArgs e)
        {
             AddComenziForm addComenziForm = new AddComenziForm();
    if (lbFinished.SelectedItem == null)
    {
        if (addComenziForm.ShowDialog() == DialogResult.OK)
        {
            bool isValid = false;
            Comenzi comanda = null;

            while (!isValid)
            {
                try
                {
                    comanda = addComenziForm.GetComenzi();
                    isValid = true;
                }
                catch (FormatException ex)
                {
                    var result = MessageBox.Show("Invalid input: " + ex.Message + "\n\nDo you want to try again?",
                        "Validation Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                    if (result == DialogResult.No)
                    {
                        isValid = true; 
                    }
                    else
                    {
                        addComenziForm = new AddComenziForm();
                        if (comanda != null)
                        {
                            addComenziForm.PopulateData(comanda); 
                        }
                        addComenziForm.ShowDialog();
                    }
                }
            }

            if (comanda != null)
            {
                lbWaiting.Items.Add(comanda);
            }
        }
    }
    else
    {
        lbWaiting.Items.Add(lbFinished.SelectedItem);
        lbFinished.Items.Remove(lbFinished.SelectedItem);
    }
        }

        private void btAddFinished_Click(object sender, EventArgs e)
        {
            AddComenziForm addComenziForm = new AddComenziForm();
            if (lbWaiting.SelectedItem == null)
            {
                if (addComenziForm.ShowDialog() == DialogResult.OK)
                {
                    bool isValid = false;
                    Comenzi comanda = null;
                    while (!isValid)
                    {
                        try
                        {
                            comanda = addComenziForm.GetComenzi();
                            isValid = true;
                        }
                        catch (FormatException ex)
                        {
                            var result = MessageBox.Show("Invalid input: " + ex.Message + "\n\nVrei sa incerci din nou?",
                                "Validation Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                            if (result == DialogResult.No)
                            {
                                isValid = true;
                            }
                            else
                            {
                                addComenziForm = new AddComenziForm();
                                if (comanda != null)
                                {
                                    addComenziForm.PopulateData(comanda); 
                                }
                                addComenziForm.ShowDialog();
                            }
                        }
                    }

                    if (comanda != null)
                    {
                        lbFinished.Items.Add(comanda);
                    }
                }
            }
            else
            {
                lbFinished.Items.Add(lbWaiting.SelectedItem);
                lbWaiting.Items.Remove(lbWaiting.SelectedItem);
            }

        }

        private void btRemoveWaiting_Click(object sender, EventArgs e)
        {
            if (lbWaiting.SelectedItem != null)
            {
                lbWaiting.Items.Remove(lbWaiting.SelectedItem);
            }
        }

        private void btRemoveFinished_Click(object sender, EventArgs e)
        {
            if (lbFinished.SelectedItem != null)
            {
                lbFinished.Items.Remove(lbFinished.SelectedItem);
            }

        }

        private void btEditFinished_Click(object sender, EventArgs e)
        {
            if (lbFinished.SelectedItem != null)
            {
                Comenzi selectedOrder = (Comenzi)lbFinished.SelectedItem;
                AddComenziForm editForm = new AddComenziForm();
                editForm.Text = "Edit Order";
                editForm.PopulateData(selectedOrder);

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    Comenzi editedOrder = editForm.GetComenzi();
                    int selectedIndex = lbFinished.SelectedIndex;
                    lbFinished.Items[selectedIndex] = editedOrder;
                }

            }

        }

        private void btEditWaiting_Click(object sender, EventArgs e)
        {
            if (lbWaiting.SelectedItem != null)
            {
                Comenzi selectedOrder = (Comenzi)lbWaiting.SelectedItem;
                AddComenziForm editForm = new AddComenziForm();
                editForm.Text = "Edit Order";
                editForm.PopulateData(selectedOrder);

                if(editForm.ShowDialog() == DialogResult.OK) 
                {
                    Comenzi editedOrder = editForm.GetComenzi();
                    int selectedIndex = lbWaiting.SelectedIndex;
                    lbWaiting.Items[selectedIndex] = editedOrder;
                }

            }

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

            GenerateInvoice generateInvoiceForm = new GenerateInvoice();
            if (lbFinished.SelectedItem != null)
            {
                if (generateInvoiceForm.ShowDialog() == DialogResult.OK)
                {
                    Facturi factura = generateInvoiceForm.GetFactura((Comenzi)lbFinished.SelectedItem);
                    txtFactura.Text =factura.ToString();
                }
            }
            if(lbWaiting.SelectedItem!=null)
            {
                if (generateInvoiceForm.ShowDialog() == DialogResult.OK)
                {
                    Facturi factura = generateInvoiceForm.GetFactura((Comenzi)lbWaiting.SelectedItem);
                    txtFactura.Text = factura.ToString();
                }
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtFactura.Text, new Font("Times New Roman", 26, FontStyle.Regular), Brushes.Black, new PointF(100, 100));
        }
    }
}
