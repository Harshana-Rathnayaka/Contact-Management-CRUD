namespace SAD_Project01
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="Form3" />
    /// </summary>
    public partial class Form3 : Form
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
        /// Defines the passingMessage
        /// </summary>
        public static string passingMessage;

        /// <summary>
        /// Initializes a new instance of the <see cref="Form3"/> class.
        /// </summary>
        public Form3()
        {
            InitializeComponent();
            timer1.Start();
            showData();
            
        }

        /// <summary>
        /// Defines the HeaderCheckBox
        /// </summary>
        internal CheckBox HeaderCheckBox = null;

        /// <summary>
        /// Defines the IsHeaderCheckBoxClicked
        /// </summary>
        internal bool IsHeaderCheckBoxClicked = false;

        /// <summary>
        /// The AddHeaderCheckBox
        /// </summary>
        private void AddHeaderCheckBox()
        {
            HeaderCheckBox = new CheckBox();

            HeaderCheckBox.Size = new Size(15, 15);

            this.dataGridView1.Controls.Add(HeaderCheckBox);
        }

        /// <summary>
        /// The HeaderCheckBoxClick
        /// </summary>
        /// <param name="HCheckBox">The HCheckBox<see cref="CheckBox"/></param>
        private void HeaderCheckBoxClick(CheckBox HCheckBox)
        {
            IsHeaderCheckBoxClicked = true;
            foreach (DataGridViewRow Row in dataGridView1.Rows)
                ((DataGridViewCheckBoxCell)Row.Cells["chk"]).Value = HCheckBox.Checked;

            dataGridView1.RefreshEdit();

            IsHeaderCheckBoxClicked = false;
        }

        /// <summary>
        /// The HeaderCheckBox_MouseClick
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="MouseEventArgs"/></param>
        private void HeaderCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            HeaderCheckBoxClick((CheckBox)sender);
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
        /// The pictureBox1_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The button2_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please select a contact.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Please enter a text message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                MessageBox.Show("Message sent successfully to : " + textBox1.Text, " Success! " + label3.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                passingMessage = textBox2.Text;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();

                this.Hide();
                Form7 f7 = new Form7();
                f7.Show();
            }
        }

        /// <summary>
        /// The button1_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
            adpt = new SqlDataAdapter("Select * from Students order by ID", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

            
        }

        /// <summary>
        /// The Form3_Load
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void Form3_Load(object sender, EventArgs e)
        {
            label3.Text = ("Logged in as " + form1.passingText);

            AddHeaderCheckBox();
            HeaderCheckBox.MouseClick += new MouseEventHandler(HeaderCheckBox_MouseClick);
        }

        /// <summary>
        /// The showData
        /// </summary>
        public void showData()
        {
            con.Open();

            adpt = new SqlDataAdapter("Select * from Students", con);
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

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox3.Focus();
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
        /// The comboBox1_MouseClick
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="MouseEventArgs"/></param>
        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        /// <summary>
        /// The comboBox1_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void comboBox1_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The comboBox1_SelectedIndexChanged
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                adpt = new SqlDataAdapter("Select * from Students order by '" + comboBox1.Text + "'", con);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
        /// The textBox3_TextChanged
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            SearchData(textBox3.Text);
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
        /// The selectedCellsButton_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void selectedCellsButton_Click(object sender, EventArgs e)
        {
            Int32 selectedCellCount =
        dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                if (dataGridView1.AreAllCellsSelected(true))
                {
                    MessageBox.Show("Select Contacts only","Error! All cells are selected",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    System.Text.StringBuilder sb =
                        new System.Text.StringBuilder();

                    for (int i = 0;
                        i < selectedCellCount; i++)
                    {
                        sb.Append("Row: ");
                        sb.Append(dataGridView1.SelectedCells[i].RowIndex
                            .ToString());
                        sb.Append(", Column: ");
                        sb.Append(dataGridView1.SelectedCells[i].ColumnIndex
                            .ToString());
                        sb.Append(Environment.NewLine);
                    }

                    sb.Append("Total: " + selectedCellCount.ToString());
                    MessageBox.Show(sb.ToString(), "Selected Cells");

                    

                    /*try
                    {
                        con.Open();
                        adpt = new SqlDataAdapter("Select * from Students where ID= " + selectedCellsButton + "", con);
                        dt = new DataTable();
                        adpt.Fill(dt);
                        dataGridView1.DataSource = dt;
                        foreach (DataRow dr in dt.Rows)
                        {

                            comboBox2.Text = dr["Contact"].ToString();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                        textBox1.Focus();
                    }*/
                }
            }
        }

        /// <summary>
        /// The dataGridView1_CellContentDoubleClick
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="DataGridViewCellEventArgs"/></param>
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
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

                    textBox1.Text = dr["Contact"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                textBox1.Focus();
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
    }
}
