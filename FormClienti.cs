using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivrariLaDomiciliu
{
    public partial class FormClienti : Form
    {
        public FormClienti()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=clientsDB;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        void GetData()
        {
            string query = "Select * FROM Clients";
            con.Open();
            da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgwClients.DataSource = dt;
            con.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Clients(Name, Gender, Age, PhoneNumber, NumberOfPreviousOrders, Address) VALUES(@name, @gender, @age, @phonenumber, @numberofpreviousorders, @address) ";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@gender", comboBoxGender.Text);
            cmd.Parameters.AddWithValue("@age", txtAge.Text);
            cmd.Parameters.AddWithValue("@phonenumber", txtPhoneNumber.Text);
            cmd.Parameters.AddWithValue("@numberofpreviousorders",txtNrPreviousOrders.Text);
            cmd.Parameters.AddWithValue("@address", txtAddress.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetData();
            MessageBox.Show("Client inserat");


        }

        private void FormClienti_Load(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
