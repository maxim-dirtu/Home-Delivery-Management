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

        void GetStats()
        {
            string query = "SELECT Gender, COUNT(*) AS NumberOfClients, SUM(NumberOfPreviousOrders) AS TotalPreviousOrders FROM Clients GROUP BY Gender";
            con.Open();
            da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            chart1.Series["Orders"].XValueMember = "Gender";
            chart1.Series["Orders"].YValueMembers = "TotalPreviousOrders";
            chart1.DataSource = dt;
            chart1.DataBind();
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
            MessageBox.Show("Client inserat.");


        }

        private void FormClienti_Load(object sender, EventArgs e)
        {
            GetData();
            GetStats();

        }

        private void dgwClients_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtClientID.Text = dgwClients.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgwClients.CurrentRow.Cells[1].Value.ToString();
            comboBoxGender.Text = dgwClients.CurrentRow.Cells[2].Value.ToString();
            txtAge.Text = dgwClients.CurrentRow.Cells[3].Value.ToString();
            txtPhoneNumber.Text = dgwClients.CurrentRow.Cells[4].Value.ToString();
            txtNrPreviousOrders.Text = dgwClients.CurrentRow.Cells[5].Value.ToString();
            txtAddress.Text = dgwClients.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Clients SET Name=@name, " +
                "Gender=@gender, " +
                "Age=@age, " +
                "PhoneNumber=@phonenumber, " +
                "NumberOfPreviousOrders=@numberofpreviousorders," +
                "Address=@address " +
                "WHERE ClientID=@clientid";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@clientid", Convert.ToInt32(txtClientID.Text));
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@gender", comboBoxGender.Text);
            cmd.Parameters.AddWithValue("@age", txtAge.Text);
            cmd.Parameters.AddWithValue("@phonenumber", txtPhoneNumber.Text);
            cmd.Parameters.AddWithValue("@numberofpreviousorders", txtNrPreviousOrders.Text);
            cmd.Parameters.AddWithValue("@address", txtAddress.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetData();
            MessageBox.Show("Client actualizat.");


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Clients WHERE ClientID=@clientid";
            cmd=new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@clientid", Convert.ToInt32(txtClientID.Text));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetData();
            MessageBox.Show("Clientul a fost sters.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtClientID.Text == "")
                GetData();
            else
            {
                string query = "Select * FROM Clients Where ClientID = '"+Convert.ToInt32(txtClientID.Text)+"' ";
                con.Open();
                da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgwClients.DataSource = dt;
                con.Close();
            }
        }
    }
}
