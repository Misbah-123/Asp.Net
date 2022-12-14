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

namespace project
{
    public partial class Criminals : Form
    {
        public Criminals()
        {
            InitializeComponent();
            ShowCriminals();
            OffNameLb1.Text = Login.OffName;
        }
        //global connection
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-DLBFHJF;Initial Catalog=policemangment;Integrated Security=True");
        private void ShowCriminals()
        {
            Con.Open();
            string Query = "Select * from criminaltb1";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CriminalDVG.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RecordBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || AddressTb.Text == "" || ActivityTb.Text == "" || ReportTb.Text == "" || DisTb.Text == "")
            {
                MessageBox.Show("Missing information!!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into criminaltb1(CrName,CrAdd,CrActivities,Report,District)values(@CN,@CA,@CrA,@Rp,@Dis)", Con);
                    cmd.Parameters.AddWithValue("@CN", NameTb.Text);
                    cmd.Parameters.AddWithValue("@CA", AddressTb.Text);
                    cmd.Parameters.AddWithValue("@CrA", ActivityTb.Text);
                    cmd.Parameters.AddWithValue("@Rp", ReportTb.Text);
                    cmd.Parameters.AddWithValue("@Dis", DisTb.Text);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Criminal Recorded");
                    Con.Close();
                    ShowCriminals();
                    Reset();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Key = 0;
        private void CriminalDVG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NameTb.Text = CriminalDVG.SelectedRows[0].Cells[1].Value.ToString();
            AddressTb.Text = CriminalDVG.SelectedRows[0].Cells[2].Value.ToString();
            ActivityTb.Text = CriminalDVG.SelectedRows[0].Cells[3].Value.ToString();
            ReportTb.Text = CriminalDVG.SelectedRows[0].Cells[4].Value.ToString();
            DisTb.Text = CriminalDVG.SelectedRows[0].Cells[5].Value.ToString();



            if (NameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(CriminalDVG.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || AddressTb.Text == "" || ActivityTb.Text == "" || ReportTb.Text == "" || DisTb.Text == "")
            {
                MessageBox.Show("Missing information!!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update criminaltb1 Set CrName=@CN,CrAdd=@CA,CrActivities=@CrA,Report=@Rp,District=@Dis where CrCode = @CKey", Con);
                    cmd.Parameters.AddWithValue("@CKey", Key);
                    cmd.Parameters.AddWithValue("@CN", NameTb.Text);
                    cmd.Parameters.AddWithValue("@CA", AddressTb.Text);
                    cmd.Parameters.AddWithValue("@CrA", ActivityTb.Text);
                    cmd.Parameters.AddWithValue("@Rp", ReportTb.Text);
                    cmd.Parameters.AddWithValue("@Dis", DisTb.Text);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Criminal Recorded");
                    Con.Close();
                    ShowCriminals();
                    Reset();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Reset()
        {
            NameTb.Text = "";
            AddressTb.Text = "";
            ActivityTb.Text = "";
            ReportTb.Text = "";
            DisTb.Text = "";
            Key = 0;

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select a Criminal!!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from criminaltb1 where CrCode = @CKey", Con);
                    cmd.Parameters.AddWithValue("@CKey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Criminal deleted");
                    Con.Close();
                    ShowCriminals();
                    Reset();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }


        private void Criminals_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Criminals obj = new Criminals();
            obj.Show();
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();

        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            Charges obj = new Charges();
            obj.Show();
            this.Hide();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            Cases obj = new Cases();
            obj.Show();
            this.Hide();
        }

        private void OffNameLb1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {

            SqlDataAdapter adapt;
            DataTable dt;

            Con.Open();
            adapt = new SqlDataAdapter("select * from criminaltb1 where CrCode like '" + cTextBox1.Text + "%'", Con);
            dt = new DataTable();
            adapt.Fill(dt);
            CriminalDVG.DataSource = dt;
            Con.Close();

        }
    }
}
    

    
