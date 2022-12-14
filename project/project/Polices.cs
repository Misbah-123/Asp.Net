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

namespace project
{
    public partial class Polices : Form
    {
        public Polices()
        {
            InitializeComponent();
            ShowPolice();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-DLBFHJF;Initial Catalog=policemangment;Integrated Security=True");
        private void ShowPolice()
        {
            Con.Open();
            string Query = "Select * from policetb1";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PolicesDVG.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Casetb_TextChanged(object sender, EventArgs e)
        {

        }
        private void Reset()
        {
            AddressTb.Text = "";
            PhoneTb.Text = "";
            DesignationCb.SelectedIndex = -1;
            PasswordTb.Text = "";
            SerialNo.Text = "";
            
            Key = 0;

        }
        private void RecordBtn_Click(object sender, EventArgs e)
        {
            if (AddressTb.Text == "" || PhoneTb.Text == "" || DesignationCb.SelectedIndex == -1 || PasswordTb.Text == "" || SerialNo.Text == "")
            {
                MessageBox.Show("Missing information!!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into policetb1(EmpName,EmpAddress,EmpPhone,EmpDes,EmpPass,SerialNo,Date)values(@EN,@EA,@EP,@ED,@EPa,@SerialNo,@Date)", Con);
                    cmd.Parameters.AddWithValue("@EN", NameTb.Text);
                    cmd.Parameters.AddWithValue("@EA", AddressTb.Text);
                    cmd.Parameters.AddWithValue("@EP", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@ED", DesignationCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@EPa", PasswordTb.Text);
                    cmd.Parameters.AddWithValue("@SerialNo", SerialNo.Text);
                    cmd.Parameters.AddWithValue("@Date", Date.Value.Date);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Officer Recorded");
                    Con.Close();
                    ShowPolice();
                    Reset();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }

            }
        }
        int Key = 0;
        private void PolicesDVG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NameTb.Text = PolicesDVG.SelectedRows[0].Cells[1].Value.ToString();
            AddressTb.Text = PolicesDVG.SelectedRows[0].Cells[2].Value.ToString();
            PhoneTb.Text = PolicesDVG.SelectedRows[0].Cells[3].Value.ToString();
            DesignationCb.SelectedItem = PolicesDVG.SelectedRows[0].Cells[4].Value.ToString();
            PasswordTb.Text = PolicesDVG.SelectedRows[0].Cells[5].Value.ToString();
            PasswordTb.Text = PolicesDVG.SelectedRows[0].Cells[5].Value.ToString();

          SerialNo.Text = PolicesDVG.SelectedRows[0].Cells[6].Value.ToString();
           Date.Text = PolicesDVG.SelectedRows[0].Cells[7].Value.ToString();


            if (NameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(PolicesDVG.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select a Police Officer!!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from policetb1 where EmpCode = @PKey", Con);
                    cmd.Parameters.AddWithValue("@PKey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Criminal deleted");
                    Con.Close();
                    ShowPolice();
                    Reset();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (AddressTb.Text == "" || PhoneTb.Text == "" || DesignationCb.SelectedIndex == -1 || PasswordTb.Text == "" || SerialNo.Text=="")
            {
                MessageBox.Show("Missing information!!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update policetb1 Set EmpName=@EN,EmpAddress=@EA,EmpPhone=@EP,EmpDes=@ED,EmpPass=@EPa, SerialNo=@Sn,Date=@Date where EmpCode=@PKey", Con);
                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.Parameters.AddWithValue("@EN", NameTb.Text);
                    cmd.Parameters.AddWithValue("@EA", AddressTb.Text);
                    cmd.Parameters.AddWithValue("@EP", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@ED", DesignationCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@EPa", PasswordTb.Text);
                    cmd.Parameters.AddWithValue("@Sn", SerialNo.Text);
                    cmd.Parameters.AddWithValue("@Date", Date.Value.Date);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Officer Recorded");
                    Con.Close();
                    ShowPolice();
                    Reset();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }


            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            //Criminals Obj = new Criminals();
            //Obj.Show();
            //this.Hide();


        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {

            SqlDataAdapter adapt;
            DataTable ds;

            Con.Open();
            adapt = new SqlDataAdapter("select * from policetb1 where SerialNo like '" + cTextBox1.Text + "%'", Con);
            ds = new DataTable();
            adapt.Fill(ds);
            PolicesDVG.DataSource = ds;
            Con.Close();

        }
    }
}
