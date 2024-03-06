using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cexolimpiada2015
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        public void SetAdminButtonVisibility(bool visible)
        {
            administrareToolStripMenuItem.Visible = visible;

        }

        public void SetTuristiButtonVisibility(bool visible)
        {
            turistiToolStripMenuItem.Visible = visible; 
        }

        private void administrareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
