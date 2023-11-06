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
            //Para fechar a Aplicação
            Application.Exit();
        }

        private void btn_acess_Click(object sender, EventArgs e)
        {
         //Variavel do tipo string que recebe da ferramenta TextBox
            string usuario = txt_User.Text;
            string senha = txt_Senha.Text;

         //A verificação da credencial para permitir o acesso
            if (senha == "123" && usuario == "admin")
            {
             //tornar esta (this) tela de login oculta (Hide)    
                this.Hide();
             //Instanciar ( é criar um Objeto) a tela de menu
                MenuTela menu = new MenuTela();
             // a tela menu ira fechar junto com a aplicação
             // Porém, ira abrir a tela menu novamente.
                menu.FormClosed += (s, args) => this.Close();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Senha ou usuário incorretos, tente novamente");
                txt_Senha.Clear();
                txt_User.Clear();
            }
        }
    }
}
