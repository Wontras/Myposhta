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
    public partial class Form3 : MaterialSkin.Controls.MaterialForm
    {
        public Form3()
        {
            InitializeComponent();
            materialTabControl1.TabIndex = 1;
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.Red400, Primary.Grey900, Primary.Grey100, Accent.DeepOrange200, TextShade.WHITE);
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton8_Click(object sender, EventArgs e)
        {
            string Login = textBox2.Text;
            string Password = textBox1.Text;
            SenderContext sc = new SenderContext();
            var user = sc.Clients.FirstOrDefault(p => p.Login == Login);
            if (user != null)
            {
                if (user.Password == Password)
                {
                    Form1 form = new Form1(user.Id);
                    form.Show();
                    this.Hide();
                }
            }
            //{
            //    Form1 f1 = new Form1(this, true);
            //    this.Visible = false;
            //    f1.ShowDialog();
            //    this.Close();
            //}
            //else if (comboBox1.Text == "Пользователь")
            //{
            //    Form1 f1 = new Form1(this, false);
            //    this.Visible = false;
            //    f1.ShowDialog();
            //    this.Close();
            //}
            //else MessageBox.Show("Неверный пароль или имя пользователя! Попробуйте заново!");
        

        //Form1 form = new Form1();
        //    form.Show();
        //    this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
            tabPage1.Hide();
            tabPage2.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            tabPage2.Hide();
            tabPage1.Show();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            var login = textBox3.Text;
            var password = textBox4.Text;
            var cpassword = textBox5.Text;
            var name = textBox6.Text;
            var surname = textBox7.Text;
            var phone_number = textBox8.Text;
            var address = textBox9.Text;
            var card_number = textBox10.Text;
            SenderContext sc = new SenderContext();
            Client cl = new Client();
            cl.Login = login;
            cl.Password = password;
            sc.Clients.Add(cl);
            sc.SaveChanges();
            Sender snd = new Sender();
            snd.Cl = cl;
            snd.Name = name;
            snd.PhoneNumber = phone_number;
            snd.Surname = surname;
            snd.Address = address;
            snd.CardNumber = card_number;
            snd.Id = cl.Id;
            sc.Senders.Add(snd);
            sc.SaveChanges();
        }
    }
}
