namespace SAD_Project01
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="Form8" />
    /// </summary>
    public partial class Form8 : Form
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
        /// Defines the id
        /// </summary>
        internal int id;

        /// <summary>
        /// Initializes a new instance of the <see cref="Form8"/> class.
        /// </summary>
        public Form8()
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
        /// The button4_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        /// <summary>
        /// The button5_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1 f1 = new form1();
            f1.Show();
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
        /// The Form8_Load
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void Form8_Load(object sender, EventArgs e)
        {
            label9.Text = ("Logged in as " + form1.passingText);
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
        /// The groupBox1_Enter
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The textBox1_TextChanged
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchData(textBox1.Text);
        }

        /// <summary>
        /// The SearchData
        /// </summary>
        /// <param name="search">The search<see cref="string"/></param>
        public void SearchData(string search)
        {
            con.Open();
            string query = "select * from Students where ID like '%" + search + "%'";
            adpt = new SqlDataAdapter(query, con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        /// <summary>
        /// The button6_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void button6_Click(object sender, EventArgs e)
        {
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
            textBox1.Clear();
            textBox1.Focus();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        /// <summary>
        /// The dataGridView1_CellClick
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="DataGridViewCellEventArgs"/></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // getting the record in to the text boxes when the user clicks on a record
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString());

            try
            {
                con.Open();
                adpt = new SqlDataAdapter("Select * from Students where ID= " + id + "", con);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                foreach (DataRow dr in dt.Rows)
                {
                    txtNIC.Text = dr["NIC"].ToString();
                    txtName.Text = dr["Name"].ToString();
                    dateTimePickerDOB.Text = dr["DOB"].ToString();
                    radioButton1.Checked = dr["Gender"].ToString() == "M";
                    radioButton2.Checked = dr["Gender"].ToString() == "F";
                    txtContact.Text = dr["Contact"].ToString();
                    txtDistrict.Text = dr["District"].ToString();
                    txtSchool.Text = dr["School"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                txtNIC.Focus();
            }
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
        /// The button2_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void button2_Click(object sender, EventArgs e)
        {
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
            textBox1.Clear();
            textBox1.Focus();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
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
            else
            {
                // updating student data
                try
                {
                    con.Open();
                    string vDate = DateTime.Parse(dateTimePickerDOB.Text).ToString("yyyy-MM-dd");
                    string sql = "UPDATE Students set NIC='" + txtNIC.Text + "',Name='" + txtName.Text + "',DOB='" + vDate + "',Contact='" + txtContact.Text + "',Gender='" + Gender + "',District='" + txtDistrict.Text + "',School='" + txtSchool.Text + "' where NIC='" + txtNIC.Text + "' ;";
                    SqlCommand exeSql = new SqlCommand(sql, con);
                    exeSql.ExecuteNonQuery();

                    MessageBox.Show("Record Updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    adpt = new SqlDataAdapter("Select * from Students where NIC= '" + txtNIC.Text + "'", con);
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
                    textBox1.Clear();
                    textBox1.Focus();
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
        /// The label8_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void label8_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The button3_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void button3_Click(object sender, EventArgs e)
        {

            // checking if any field is empty 

            if (txtNIC.Text == "" || txtName.Text == "" || txtContact.Text == "" || txtDistrict.Text == "" || txtSchool.Text == "" || dateTimePickerDOB.Text == "")
            {
                MessageBox.Show("One or more fields are empty!", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    con.Open();

                    string sql = "delete from Students where NIC='" + txtNIC.Text + "' ;";
                    SqlCommand exeSql = new SqlCommand(sql, con);
                    exeSql.ExecuteNonQuery();

                    MessageBox.Show("Record Deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    textBox1.Clear();
                    textBox1.Focus();
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
        /// The txtContact_TextChanged
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void txtContact_TextChanged(object sender, EventArgs e)
        {
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
