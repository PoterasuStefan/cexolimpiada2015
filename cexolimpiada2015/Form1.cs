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
    public partial class Form1 : Form
    {

        Form2  form2 = new Form2 ();
        
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
        }


        string AdminAcount = "Administrator" , AdminPassword = "agentie2015";
        string TuristaAccount = "Turist", TuristPassword = "oti2015";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == AdminAcount&& textBox2.Text == AdminPassword)
            {
                form2.SetAdminButtonVisibility(true);
                form2.SetTuristiButtonVisibility(false);
            }
            else if (textBox1.Text == TuristaAccount && textBox2.Text == TuristPassword)
            {
                form2.SetAdminButtonVisibility(false);
                form2.SetTuristiButtonVisibility(true);
            }
            form2.Show();
            this.Hide();
        }
    }
}
