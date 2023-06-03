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
            if (ValidateInputs())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                txtID.Text = string.Empty;
                txtWeight.Text = string.Empty;
                txtDeliveredItem.Text = string.Empty;
                txtDestinationAddress.Text = string.Empty;
                txtReceiverName.Text = string.Empty;
                txtSenderName.Text = string.Empty;
                checkIsFragile.Checked = false;
                dtpDeliveryDate.Value = DateTime.Now;
            }
        }

        private bool ValidateInputs()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtID.Text))
                {
                    MessageBox.Show("Please enter a valid ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (!int.TryParse(txtID.Text, out _))
                {
                    MessageBox.Show("Please enter a valid integer value for ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(txtWeight.Text))
                {
                    MessageBox.Show("Please enter a valid weight.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (!float.TryParse(txtWeight.Text, out float weight))
                {
                    MessageBox.Show("Please enter a valid floating-point value for weight.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(txtDeliveredItem.Text))
                {
                    MessageBox.Show("Please enter a delivered item.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(txtDestinationAddress.Text))
                {
                    MessageBox.Show("Please enter a destination address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(txtReceiverName.Text))
                {
                    MessageBox.Show("Please enter a receiver name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(txtSenderName.Text))
                {
                    MessageBox.Show("Please enter a sender name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Add additional validations for other textboxes if needed

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during validation: " + ex.Message + "\n\nStack Trace:\n" + ex.StackTrace,
            "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
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
