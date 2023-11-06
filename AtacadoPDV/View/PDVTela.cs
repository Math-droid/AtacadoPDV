using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtacadoPDV.View
{

    public partial class PDVTela : Form

    {  //para que essa variavel não resetara a cada vez que
       //o btn_click ser executado
       // foi colocado aqui
        int total = 0;

        public PDVTela()
        {
            InitializeComponent();

        }

        private void bnt_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bnt_pastel_Click(object sender, EventArgs e)
        {
            string registroPastel = "10";
            txb_cod.Text = registroPastel;

        }

        private void bnt_coxinha_Click(object sender, EventArgs e)
        {
            string registroCoxinha = "11";
            txb_cod.Text = registroCoxinha;
            ;
        }

        private void bnt_esfiha_Click(object sender, EventArgs e)
        {
            string registroEsfiha = "12";
            txb_cod.Text = registroEsfiha;

        }

        private void bnt_BolQj_Click(object sender, EventArgs e)
        {
            string registroBolQj = "13";
            txb_cod.Text = registroBolQj;

        }

        private void bnt_suco_Click(object sender, EventArgs e)
        {
            string registroSuco = "14";
            txb_cod.Text = registroSuco;

        }

        private void bnt_cafe_Click(object sender, EventArgs e)
        {
            string registroCafe = "15";
            txb_cod.Text = registroCafe;

        }

        private void bnt_refri_Click(object sender, EventArgs e)
        {
            string registroRefri = "16";
            txb_cod.Text = registroRefri;

        }

        private void bnt_add_Click(object sender, EventArgs e)
        {
            //Foi feito um banco de dados dentro das Arrays, contento o valor, itens e unidades 
            int[] valor = { 8, 8, 8, 8, 12, 10, 15 };
            string[] itens = { "Pastel", "Coxinha", "Esfiha", "Bolinho de Queijo", "Sucos", "Refrigerante", "Café" };
            int[] un = { 1, 8, 1, 8, 1, 1, 1 };

            //converte o que está na variavel (txb_cod.Text) em inteiro
            int codigo = Convert.ToInt32(txb_cod.Text);
            // como os codigos tem uma sequência, foi subtraido por 10 para extrair
            //o que está nas arrays
            codigo -= 10;
            int Qtde = ((int)qtd.Value);
            // multiplica a quantidade pelo valor
            int val = Qtde * valor[codigo];
            total += val;
            grid_prod.Rows.Add(itens[codigo], Qtde, un[codigo], valor[codigo], val);
            txb_valTo.Text = "R$" + total.ToString() + ",00";

        }

        private void bnt_clear_Click(object sender, EventArgs e)
        {
            txb_valTo.Text = string.Empty;
            txb_cod.Text += string.Empty;
            qtd.Value = 0;
            grid_prod.Rows.Clear();
            total = 0;
        }

        private void bnt_final_Click(object sender, EventArgs e)
        {
            if (total = 0)
            {

            }
                
                
                TelaFecharVenda telafechar = new TelaFecharVenda();
            telafechar.Show();
        }
    }
}
