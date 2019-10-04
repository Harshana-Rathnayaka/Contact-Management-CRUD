namespace SAD_Project01
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="Form11" />
    /// </summary>
    public partial class Form11 : Form
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
        /// Initializes a new instance of the <see cref="Form11"/> class.
        /// </summary>
        public Form11()
        {
            InitializeComponent();
            timer1.Start();
            showData();
        }

        /// <summary>
        /// The Form11_Load
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void Form11_Load(object sender, EventArgs e)
        {
            label8.Text = ("Logged in as " + form1.passingText);
        }

        /// <summary>
        /// The showData
        /// </summary>
        public void showData()
        {
            // displaying data on form load
            try
            {
                con.Open();

                adpt = new SqlDataAdapter("Select * from Students order by ID", con);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
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

        /// <summary>
        /// The button3_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void button3_Click(object sender, EventArgs e)
        {
            // refreshing the data 
            try
            {
                con.Open();

                adpt = new SqlDataAdapter("Select * from Students order by ID", con);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();

            }

            txtID.Clear();
            txtNIC.Clear();
            txtName.Clear();
            txtContact.Clear();
            textBox1.Clear();
            textBox1.Focus();
        }

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
        /// The label5_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void label5_Click(object sender, EventArgs e)
        {
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
        /// The dataGridView1_CellClick
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="DataGridViewCellEventArgs"/></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // getting the record in to the text boxes when the user clicks on a record
            try
            {
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                con.Open();
                adpt = new SqlDataAdapter("Select * from Students where ID= " + id + "", con);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                foreach (DataRow dr in dt.Rows)
                {
                    txtID.Text = dr["ID"].ToString();
                    txtNIC.Text = dr["NIC"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                txtName.Focus();
            }
        }

        /// <summary>
        /// The button2_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void button2_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtNIC.Clear();
            txtName.Clear();
            txtContact.Clear();
            textBox1.Clear();
            textBox1.Focus();
        }

        /// <summary>
        /// The button1_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // checking if any field is empty
            if (txtName.Text == "" || txtContact.Text == "")
            {
                MessageBox.Show("One or more fields are empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                // inserting data into Parents table
                try
                {
                    con.Open();
                    string sql = "INSERT INTO Parents (Student_ID,Student_NIC,Parent_Name,Parent_Contact) values(" + txtID.Text + ",'" + txtNIC.Text + "','" + txtName.Text + "','" + txtContact.Text + "')";
                    SqlCommand exeSql = new SqlCommand(sql, con);
                    exeSql.ExecuteNonQuery();

                    MessageBox.Show("Saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    adpt = new SqlDataAdapter("Select * from Parents where Student_NIC= '" + txtNIC.Text + "'", con);
                    dt = new DataTable();
                    adpt.Fill(dt);
                    dataGridView1.DataSource = dt;

                    txtID.Clear();
                    txtNIC.Clear();
                    txtName.Clear();
                    txtContact.Clear();
                    textBox1.Focus();

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
