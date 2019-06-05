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

namespace Myposhta
{
    public partial class Form2 : MaterialSkin.Controls.MaterialForm
    {
        public Form2(Mail mail_obj, int id)
        {
            user_id = id;
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.Red400, Primary.Grey900, Primary.Grey100, Accent.DeepOrange200, TextShade.WHITE);
            anyone = mail_obj;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton7_Click(object sender, EventArgs e)
        {
            MailContext PostOffice = new MailContext();
            SenderContext sx = new SenderContext();
            //Text = textBox5.Text;
            //anyone.Snd = sx.Senders.ToList()[user_id - 1];
            anyone.SenderId = user_id;
            label3.Text = user_id.ToString();
            PostOffice.Mails.Add(anyone);
            PostOffice.SaveChanges();
            //Random runt = new Random();
            //label3.Text = runt.Next().ToString();
            materialTabControl1.SelectedIndex = 1;
            

          
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
