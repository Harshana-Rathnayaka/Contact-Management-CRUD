namespace SAD_Project01
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="Form5" />
    /// </summary>
    public partial class Form5 : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form5"/> class.
        /// </summary>
        public Form5()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The button1_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ss = new Form2();
            ss.Show();
        }

        /// <summary>
        /// The button2_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// The Form5_Load
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void Form5_Load(object sender, EventArgs e)
        {
        }
    }
}
