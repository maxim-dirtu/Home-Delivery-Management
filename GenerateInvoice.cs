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
    public partial class GenerateInvoice : Form
    {
        public GenerateInvoice()
        {
            InitializeComponent();
        }

        private void txtDeliveryPersonName_TextChanged(object sender, EventArgs e)
        {

        }

        public Facturi GetFactura(Comenzi comanda)
        {
            string DeliveryPersonName = txtDeliveryPersonName.Text;
            float DeliveryPrice = float.Parse(txtDeliveryPrice.Text);
            string PaymentMethod = comboBoxPaymentMethod.Text;

            Facturi factura = new Facturi(comanda, DeliveryPersonName, DeliveryPrice, PaymentMethod);
            return factura;
        }

        private void btnCancelGeneration_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
