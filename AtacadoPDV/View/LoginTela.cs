using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtacadoPDV.View
{
    public partial class LoginTela : Form
    {
        public LoginTela()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txt_User.Text;
            string senha = txt_Senha.Text;
            if(senha == "123" && usuario == "admin")
            {
                this.Visible = false;                                                                                   
                MenuTela menu = new MenuTela();
                menu.Show(this);
            }else
            {
                MessageBox.Show("Senha ou usuário incorretos, tente novamente");
            }
        }
    }
}
