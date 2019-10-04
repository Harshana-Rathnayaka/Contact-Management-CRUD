namespace SAD_Project01
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="Form6" />
    /// </summary>
    public partial class Form6 : Form
    {
        /// <summary>
        /// Defines the con
        /// </summary>
        internal SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F77N9QS\SQLEXPRESS;Initial Catalog=SAD;Integrated Security=True");

        /// <summary>
        /// Defines the adpt
        /// </summary>
        internal SqlDataAdapter adpt;

        /// <summary>
        /// Defines the dt
        /// </summary>
        internal DataTable dt;

        /// <summary>
        /// Initializes a new instance of the <see cref="Form6"/> class.
        /// </summary>
        public Form6()
        {
            InitializeComponent();
            timer1.Start();
            showData();
        }

        /// <summary>
        /// Defines the Gender
        /// </summary>
        internal string Gender;

        /// <summary>
        /// The label1_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void label1_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The label2_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void label2_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The label5_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void label5_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The Form6_Load
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void Form6_Load(object sender, EventArgs e)
        {
            label8.Text = ("Logged in as " + form1.passingText);
        }

        /// <summary>
        /// The showData
        /// </summary>
        public void showData()
        {
            con.Open();

            adpt = new SqlDataAdapter("Select * from Students order by ID", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        /// <summary>
        /// The textBox1_TextChanged
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The button1_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // checking if any field is empty 

            if (txtNIC.Text == "" || txtName.Text == "" || txtContact.Text == "" || txtDistrict.Text == "" || txtSchool.Text == "" || dateTimePickerDOB.Text == "")
            {
                MessageBox.Show("One or more fields are empty!", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((radioButton1.Checked == false) && (radioButton2.Checked == false))
            {
                MessageBox.Show("Please select the Gender.", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // inserting data into Students table
                try
                {
                    con.Open();
                    string vDate = DateTime.Parse(dateTimePickerDOB.Text).ToString("yyyy-MM-dd");
                    string sql = "INSERT INTO Students (NIC,Name,DOB,Contact,Gender,District,School) values(" + txtNIC.Text + ",'" + txtName.Text + "','" + vDate + "','" + txtContact.Text + "','" + Gender + "','" + txtDistrict.Text + "','" + txtSchool.Text + "')";
                    SqlCommand exeSql = new SqlCommand(sql, con);
                    exeSql.ExecuteNonQuery();

                    MessageBox.Show("Saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    adpt = new SqlDataAdapter("Select * from Students where NIC= '" + txtNIC.Text + "'", con);
                    dt = new DataTable();
                    adpt.Fill(dt);
                    dataGridView1.DataSource = dt;


                    txtNIC.Clear();
                    txtName.Clear();
                    dateTimePickerDOB.ResetText();
                    txtContact.Clear();
                    txtDistrict.Clear();
                    txtSchool.Clear();
                    txtNIC.Focus();
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        /// <summary>
        /// The button3_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();

            adpt = new SqlDataAdapter("Select * from Students order by ID", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            txtNIC.Clear();
            txtName.Clear();
            dateTimePickerDOB.ResetText();
            txtContact.Clear();
            txtDistrict.Clear();
            txtSchool.Clear();
            txtNIC.Focus();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        /// <summary>
        /// The button2_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void button2_Click(object sender, EventArgs e)
        {
            txtNIC.Clear();
            txtName.Clear();
            dateTimePickerDOB.ResetText();
            txtContact.Clear();
            txtDistrict.Clear();
            txtSchool.Clear();
            txtNIC.Focus();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        /// <summary>
        /// The dataGridView1_CellContentClick
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="DataGridViewCellEventArgs"/></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        /// <summary>
        /// The dataGridView1_CellContentClick_1
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="DataGridViewCellEventArgs"/></param>
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        /// <summary>
        /// The label8_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void label8_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The timer1_Tick
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.time_lbl.Text = dateTime.ToString();
        }

        /// <summary>
        /// The txtGender_TextChanged
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void txtGender_TextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The button5_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1 ss = new form1();
            ss.Show();
        }

        /// <summary>
        /// The button4_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ss = new Form2();
            ss.Show();
        }

        /// <summary>
        /// The groupBox1_Enter
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The radioButton1_CheckedChanged
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "M";
        }

        /// <summary>
        /// The radioButton2_CheckedChanged
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "F";
        }

        /// <summary>
        /// The txtContact_KeyPress
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="KeyPressEventArgs"/></param>
        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows digits only
            char ch = e.KeyChar;

            if (ch == 46 && txtContact.Text.IndexOf('.') != 0)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
