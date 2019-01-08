using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YYSB");
            this.BackgroundImage = Image.FromFile(Application.StartupPath+@"\1234.png");
            this.Width =325;
            this.Height = 678;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
