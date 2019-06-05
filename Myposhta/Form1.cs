using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;


namespace Myposhta
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1(int Id)
        {
            user_id = Id;
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.Red400, Primary.Grey900, Primary.Grey100, Accent.DeepOrange200, TextShade.WHITE);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 3;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 2;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 1;
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 2;
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {

            materialTabControl1.SelectedIndex = 0;
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 3;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 4;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton7_Click(object sender, EventArgs e)
        {
            MailContext PostOffice = new MailContext();
            Mail list = new Mail();
            
            int visota = Convert.ToInt32(textBox16.Text);
            int dovchina = Convert.ToInt32(textBox14.Text);
            int shirina = Convert.ToInt32(textBox15.Text);
            int cina = Convert.ToInt32(textBox10.Text);
            string cityfrom = comboBox1.Text;
            string cityto = comboBox4.Text;
            bool pakuvanna = false;
            if (materialCheckBox1.Checked)
            {
                pakuvanna = true;
            }
            bool baking = false;
            if (materialCheckBox2.Checked)
            {
                baking = true;
            }
            
            Text = textBox2.Text;
            list.Mass = Convert.ToInt32(Text);
            list.Height = visota;
            list.Width = shirina;
            list.Length = dovchina;
            list.Price = cina;
            list.Packaging = pakuvanna;
            list.Backmail = baking;
            list.City1 = cityfrom;
            list.City2 = cityto;
            list.Status = "In start city";
            //list.SenderName = "Popov";
            //PostOffice.Mails.Add(list);
            //PostOffice.SaveChanges();
            Form2 form = new Form2(list, user_id);
            form.Show();
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 5;
            MailContext mx = new MailContext();
            dataGridView1.DataSource = mx.Mails.Where(p =>p.SenderId==user_id).ToList();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            MailContext mx = new MailContext();
            switch (comboBox5.SelectedIndex)
            { 
                case 0:
                    dataGridView1.DataSource = mx.Mails.Where(p => p.SenderId == user_id).OrderBy(p => p.Id).ToList();
                    break;
                case 1:
                    dataGridView1.DataSource = mx.Mails.Where(p => p.SenderId == user_id).OrderBy(p => p.Mass).ToList();
                    break;
                case 2:
                    dataGridView1.DataSource = mx.Mails.Where(p => p.SenderId == user_id).OrderBy(p => p.Price).ToList();
                    break;
            }
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
