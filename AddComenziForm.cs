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
    public partial class AddComenziForm : Form
    {
        public AddComenziForm()
        {
            InitializeComponent();
        }
        public Comenzi GetComenzi()
        {
            int id = int.Parse(txtID.Text);
            float weight = float.Parse(txtWeight.Text);
            string deliveredItem = txtDeliveredItem.Text;
            string destinationAddress = txtDestinationAddress.Text;
            string receiverName = txtReceiverName.Text;
            string senderName = txtSenderName.Text;
            bool isFragile = checkIsFragile.Checked;
            DateTime deliveryDate = dtpDeliveryDate.Value;

            Comenzi comanda = new Comenzi(id, weight, deliveredItem, destinationAddress, receiverName, senderName, isFragile, deliveryDate);
            return comanda;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        public void PopulateData(Comenzi comenzi)
        {
            
            txtID.Text = comenzi.id.ToString();
            txtWeight.Text = comenzi.weight.ToString();
            txtDeliveredItem.Text = comenzi.deliveredItem;
            txtDestinationAddress.Text = comenzi.destinationAdress;
            txtReceiverName.Text = comenzi.receiverName;
            txtSenderName.Text = comenzi.senderName;
            checkIsFragile.Checked = comenzi.isFragile;
            dtpDeliveryDate.Value = comenzi.deliveryDate;
        }
    }
}
