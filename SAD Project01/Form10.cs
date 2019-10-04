namespace SAD_Project01
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="Form10" />
    /// </summary>
    public partial class Form10 : Form
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
        /// Initializes a new instance of the <see cref="Form10"/> class.
        /// </summary>
        public Form10()
        {
            InitializeComponent();
            timer1.Start();
            showData();
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
        /// The time_lbl_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void time_lbl_Click(object sender, EventArgs e)
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
            //searching data bt student ID
            try
            {

                con.Open();
                string query = "select * from Parents where Student_NIC like '%" + search + "%'";
                adpt = new SqlDataAdapter(query, con);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
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
        /// The button6_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void button6_Click(object sender, EventArgs e)
        {
            // refreshing the data 
            try
            {
                con.Open();

                adpt = new SqlDataAdapter("Select * from Parents order by Student_ID", con);
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
                textBox1.Clear();
                textBox1.Focus();
            }
        }

        /// <summary>
        /// The label1_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void label1_Click(object sender, EventArgs e)
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
        /// The Form10_Load
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void Form10_Load(object sender, EventArgs e)
        {
            label1.Text = ("Logged in as " + form1.passingText);
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

                adpt = new SqlDataAdapter("Select * from Parents order by Student_ID", con);
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
    }
}
