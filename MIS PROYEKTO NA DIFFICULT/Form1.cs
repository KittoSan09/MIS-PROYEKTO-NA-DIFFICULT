using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MIS_PROYEKTO_NA_DIFFICULT
{
    public partial class Form1 : Form
    {

        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;

        public Form1()
        {
            InitializeComponent();
        }

        void GetCustomers()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0; Data Source=Employee List.accdb");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT *FROM Employee_List", conn);
            conn.Open();
            adapter.Fill(dt);
            dgvEmployeeList.DataSource = dt;
            conn.Close();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employee_ListDataSet2.Employee_List' table. You can move, or remove it, as needed.
            this.employee_ListTableAdapter2.Fill(this.employee_ListDataSet2.Employee_List);


            GetCustomers();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Employee_List ([Employee ID],[Last Name],[First Name],[Position],[Birth Date],[Sex],[Full Time]) VALUES" + 
                "(@employee_id,@last_name, @first_name, @position, @birth_date, @sex, @full_time)";


            cmd = new OleDbCommand(query,conn);
            cmd.Parameters.AddWithValue("@employee_id", idBox.Text);
            cmd.Parameters.AddWithValue("@last_name", LNameBox.Text);
            cmd.Parameters.AddWithValue("@first_name", FNameBox.Text);
            cmd.Parameters.AddWithValue("@position", positionBox.Text);
            cmd.Parameters.AddWithValue("@birth_date", BdayBox.Text);
            cmd.Parameters.AddWithValue("@sex", sexBox.Text);
            cmd.Parameters.AddWithValue("@full_time", fulltimeCheckbox.Checked);




            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Employee data added.");
            GetCustomers();
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Employee_List WHERE [Employee ID] = @employee_id";
            cmd = new OleDbCommand(query, conn);

            cmd.Parameters.AddWithValue("@employee_id", Convert.ToInt32(idBox.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Employee data deleted");
            GetCustomers();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

           

            string query = "UPDATE Employee_List SET [Last Name]= @last_name, [First Name]= @first_name, [Position]= @position, [Birth Date]= @birth_date, [Sex]= @sex, [Full Time]= @full_time WHERE [Employee ID] = @id";



            cmd = new OleDbCommand(query, conn);

            cmd.Parameters.AddWithValue("@last_name", LNameBox.Text);
            cmd.Parameters.AddWithValue("@first_name", FNameBox.Text);
            cmd.Parameters.AddWithValue("@position", positionBox.Text);
            cmd.Parameters.AddWithValue("@birth_date", BdayBox.Text);
            cmd.Parameters.AddWithValue("@sex", sexBox.Text);
            cmd.Parameters.AddWithValue("@full_time", fulltimeCheckbox.Checked);
            cmd.Parameters.AddWithValue("@id",Convert.ToInt32(idBox.Text));

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Employee data updated.");
            GetCustomers();
        }

        private void dgvEmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEmployeeList_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            idBox.Text = dgvEmployeeList.CurrentRow.Cells[0].Value.ToString();
            LNameBox.Text = dgvEmployeeList.CurrentRow.Cells[1].Value.ToString();
            FNameBox.Text = dgvEmployeeList.CurrentRow.Cells[2].Value.ToString();
            positionBox.Text = dgvEmployeeList.CurrentRow.Cells[3].Value.ToString();
            BdayBox.Text = dgvEmployeeList.CurrentRow.Cells[4].Value.ToString();
            sexBox.Text = dgvEmployeeList.CurrentRow.Cells[5].Value.ToString();
            fulltimeCheckbox.Text = dgvEmployeeList.CurrentRow.Cells[6].Value.ToString();

        }
    }
}
