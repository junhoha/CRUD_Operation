using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace CRUD_Operation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetStudendRecord();
        }
        SqlConnection con = new SqlConnection(@"Data Source=INFORMATICS;Initial Catalog=IT4SoluationTEST;Integrated Security=True");
        public int StudentID;
        private void GetStudendRecord()
        {
        
            SqlCommand cmd = new SqlCommand("Select * from StudentTB", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            StudentGridview.DataSource = dt;
            //throw new NotImplementedException();
        }

        private void In_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO StudentTB VALUES (@Name, @Fathername, @RollNumber, @Address, @Mobile)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Name", txtStudentName.Text);
                cmd.Parameters.AddWithValue("@Fathername", txtFatherName.Text);
                cmd.Parameters.AddWithValue("@RollNumber", txtRollnumber.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New student is sucessfully save in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetStudendRecord();
                Resetrecored();
            }
        }

        private bool IsValid()
        {
            if(txtStudentName.Text == string.Empty)
            {
                MessageBox.Show("Student Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Resetrecored();
        }

        private void Resetrecored()
        {
            StudentID = 0;
            txtStudentName.Clear();
            txtFatherName.Clear();
            txtRollnumber.Clear();
            txtMobile.Clear();
            txtAddress.Clear();
        }

        private void StudentGridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentID = Convert.ToInt32(StudentGridview.SelectedRows[0].Cells[0].Value);
            txtStudentName.Text = StudentGridview.SelectedRows[0].Cells[1].Value.ToString();
            txtFatherName.Text = StudentGridview.SelectedRows[0].Cells[2].Value.ToString();
            txtRollnumber.Text = StudentGridview.SelectedRows[0].Cells[3].Value.ToString();
            txtMobile.Text = StudentGridview.SelectedRows[0].Cells[4].Value.ToString();
            txtAddress.Text = StudentGridview.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(StudentID > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE StudentTB SET Name = @Name, Fathername = @Fathername, RollNumber = @RollNumber, Address = @Address, Mobile = @Mobile WHERE StudentID = @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Name", txtStudentName.Text);
                cmd.Parameters.AddWithValue("@Fathername", txtFatherName.Text);
                cmd.Parameters.AddWithValue("@RollNumber", txtRollnumber.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);
                cmd.Parameters.AddWithValue("@ID", this.StudentID);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Student Information is updated sucessfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetStudendRecord();
                Resetrecored();
            }
            else
            {
                MessageBox.Show("Please Select an student to update his information", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(StudentID > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM StudentTB  WHERE StudentID = @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", this.StudentID);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Student is deleted sucessfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetStudendRecord();
                Resetrecored();
            }
            else
            {
                MessageBox.Show("Please Select an student to delete", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
