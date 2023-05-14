using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrzavnaMaturaPetar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            if (comboBox1.Text != "" && comboBox2.Text != "") { f2.Show(); this.Hide(); }
            else MessageBox.Show("Niste uneli neki obavezan podatak", "Error 404");
        }

        
    }
}
