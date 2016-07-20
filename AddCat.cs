using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Kotki
{
    public partial class AddCat : Form
    {
        public AddCat()
        {
            InitializeComponent();
        }

        private void bnew_Click(object sender, EventArgs e)
        {
            try {
                panel1.Enabled = true;
                App.Cats.AddCatsRow(App.Cats.NewCatsRow());
                catsBindingSource.MoveLast();
                textBox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                App.Cats.RejectChanges();
            }
            
        }

        private void bedit_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            textBox1.Focus();
        }

        private void bcancel_Click(object sender, EventArgs e)
        {
            catsBindingSource.ResetBindings(false);
            textBox_image_path.Text = null;
            panel1.Enabled = false;
        }

        private void bsave_Click(object sender, EventArgs e)
        {
            try
            {
                catsBindingSource.EndEdit();
                App.Cats.AcceptChanges();
                App.Cats.WriteXml(string.Format("{0}//data.dat", Application.StartupPath));
                panel1.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                App.Cats.RejectChanges();
            }
        }

        static DataSet1 db;
        protected static DataSet1 App
        {
            get
            {
                if (db == null)
                    db = new DataSet1();
                return db;
            }
        }

        private void AddCat_Load(object sender, EventArgs e)
        {
            string fileName = string.Format("{0}//data.dat", Application.StartupPath);
            if (File.Exists(fileName))
                App.Cats.ReadXml(fileName);
            catsBindingSource.DataSource = App.Cats;
            panel1.Enabled = false; 

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    catsBindingSource.RemoveCurrent();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "BMP Files(*.bmp)|*.bmp|All Files(*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picLoc = dlg.FileName.ToString();
              // textBox_image_path.Text = picLoc;
                pictureBox1.ImageLocation = picLoc;

                //Read the bitmap.
               // string data = null;
                
                Bitmap bmp = new Bitmap(picLoc);
                using (MemoryStream mem = new MemoryStream())
                {
                    bmp.Save(mem, System.Drawing.Imaging.ImageFormat.Bmp);
                    //Convert the bytes to a string.
                   string data = Convert.ToBase64String(mem.ToArray());
                   textBox_image_path.Text = data;

                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
}
}
