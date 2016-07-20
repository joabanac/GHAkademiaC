using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kotki
{
    public partial class YourCat : Form
    {
        public YourCat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChooseCat f4 = new ChooseCat();
            f4.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddCat f5 = new AddCat();
            f5.ShowDialog();
        }
    }
}
