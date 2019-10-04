namespace SAD_Project01
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Threading;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="form1" />
    /// </summary>
    public partial class form1 : Form
    {
        /// <summary>
        /// Defines the con
        /// </summary>
        internal SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F77N9QS\SQLEXPRESS;Initial Catalog=SAD;Integrated Security=True");

        /// <summary>
        /// Defines the passingText
        /// </summary>
        public static string passingText;

        /// <summary>
        /// Initializes a new instance of the <see cref="form1"/> class.
        /// </summary>
        public form1()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
            FillCombo();
        }

        /// <summary>
        /// The StartForm
        /// </summary>
        public void StartForm()
        {
            Application.Run(new Form13());
        }

        /// <summary>
        /// The FillCombo
        /// </summary>
        internal void FillCombo()
        {
            try
            {
                /* 
                 // another way to get values to combobox
                
                 con.Open();
                 string sql = "Select Username from users order by Username ;";
                 SqlCommand exeSql = new SqlCommand(sql, con);
                 SqlDataReader rdr = exeSql.ExecuteReader();

                 while (rdr.Read())
                 {
                     String uName = rdr["Username"].ToString();
                     comboBox1.Items.Add(uName);
                 }
             }*/



                string sql = "Select Username from users order by Username ;";
                SqlCommand exeSql = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(exeSql);
                da.SelectCommand.CommandText = exeSql.CommandText.ToString();
                DataTable dt = new DataTable();

                da.Fill(dt);
                comboBox1.DataSource = dt;

                comboBox1.DisplayMember = "Username";
                comboBox1.ValueMember = "Username";


                con.Open();


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
        /// The form1_Load
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void form1_Load(object sender, EventArgs e)
        {
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
        /// The label2_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void label2_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The comboBox1_SelectedIndexChanged
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
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
        /// The button1_Click_2
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void button1_Click_2(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                MessageBox.Show("Please enter your password.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtpass.Focus();
            }
            else
            {
                try
                {

                    // checking whether the username password is correct with the database
                    SqlCommand cmd = new SqlCommand("select * from users where Username=@UserName and Password=@UserPass", con);
                    cmd.Parameters.AddWithValue("UserName", comboBox1.Text);
                    cmd.Parameters.AddWithValue("UserPass", txtpass.Text);

                    con.Open();
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adpt.Fill(ds);
                    con.Close();


                    int count = ds.Tables[0].Rows.Count;

                    if (count == 1)
                    {
                        // Message box with the username if the credentials are correct
                        MessageBox.Show("Have a Nice Day!! ", "Welcome : " + comboBox1.Text);
                        this.Hide();
                        passingText = comboBox1.Text;
                        Form2 fm2 = new Form2();
                        fm2.Show();

                    }
                    else
                    {
                        //error message if the credentials are incorrect
                        MessageBox.Show("The Password is Incorrect. Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        txtpass.Clear();
                        txtpass.Focus();
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// The button2_Click_1
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// The textBox2_TextChanged
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
