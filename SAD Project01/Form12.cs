namespace SAD_Project01
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="Form12" />
    /// </summary>
    public partial class Form12 : Form
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
        /// Initializes a new instance of the <see cref="Form12"/> class.
        /// </summary>
        public Form12()
        {
            InitializeComponent();
            timer1.Start();
            showData();
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
        /// The Form12_Load
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void Form12_Load(object sender, EventArgs e)
        {
            label8.Text = ("Logged in as " + form1.passingText);
            textBox1.Focus();
        }

        /// <summary>
        /// The showData
        /// </summary>
        public void showData()
        {
            con.Open();

            adpt = new SqlDataAdapter("Select * from Parents order by Student_ID", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        /// <summary>
        /// The button2_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void button2_Click(object sender, EventArgs e)
        {
            adpt = new SqlDataAdapter("Select * from Parents order by Student_ID", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

            txtID.Clear();
            txtNIC.Clear();
            txtName.Clear();
            txtContact.Clear();
            textBox1.Focus();
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
            string query = "select * from Parents where Student_ID like '%" + search + "%'";
            adpt = new SqlDataAdapter(query, con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        /// <summary>
        /// The button3_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void button3_Click(object sender, EventArgs e)
        {
            adpt = new SqlDataAdapter("Select * from Parents order by Student_ID", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

            txtID.Clear();
            txtNIC.Clear();
            txtName.Clear();
            txtContact.Clear();
            textBox1.Clear();
            textBox1.Focus();
        }

        /// <summary>
        /// The button6_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void button6_Click(object sender, EventArgs e)
        {

            // checking if any field is empty
            if (txtName.Text == "" || txtContact.Text == "")
            {
                MessageBox.Show("One or more fields are empty!", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // updating Parent data
                try
                {
                    con.Open();
                    string sql = "UPDATE Parents set Parent_Name='" + txtName.Text + "',Parent_Contact='" + txtContact.Text + "' where Student_NIC='" + txtNIC.Text + "' ;";
                    SqlCommand exeSql = new SqlCommand(sql, con);
                    exeSql.ExecuteNonQuery();

                    MessageBox.Show("Record Updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    adpt = new SqlDataAdapter("Select * from Parents where Student_ID= '" + txtID.Text + "'", con);
                    dt = new DataTable();
                    adpt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();


                    txtID.Clear();
                    txtNIC.Clear();
                    txtName.Clear();
                    txtContact.Clear();
                    textBox1.Clear();
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
        /// The dataGridView1_CellClick
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="DataGridViewCellEventArgs"/></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // getting the record in to the text boxes when the user clicks on a record
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Student_ID"].Value.ToString());

            try
            {
                con.Open();
                adpt = new SqlDataAdapter("Select * from Parents where Student_ID= " + id + "", con);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                foreach (DataRow dr in dt.Rows)
                {
                    txtID.Text = dr["Student_ID"].ToString();
                    txtNIC.Text = dr["Student_NIC"].ToString();
                    txtName.Text = dr["Parent_Name"].ToString();
                    txtContact.Text = dr["Parent_Contact"].ToString();

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
        /// The button1_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // checking if any field is empty
            if (txtID.Text == "" || txtNIC.Text == "" || txtName.Text == "" || txtContact.Text == "")
            {
                MessageBox.Show("One or more fields are empty!", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    con.Open();

                    string sql = "delete from Parents where Student_NIC='" + txtNIC.Text + "' ;";
                    SqlCommand exeSql = new SqlCommand(sql, con);
                    exeSql.ExecuteNonQuery();

                    MessageBox.Show("Record Deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    adpt = new SqlDataAdapter("Select * from Parents order by Student_ID", con);
                    dt = new DataTable();
                    adpt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();

                    txtID.Clear();
                    txtNIC.Clear();
                    txtName.Clear();
                    txtContact.Clear();
                    textBox1.Clear();
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
