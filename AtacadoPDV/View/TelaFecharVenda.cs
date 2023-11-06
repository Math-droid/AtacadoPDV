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
    public partial class TelaFecharVenda : Form
    {
        public TelaFecharVenda()
        {
            InitializeComponent();
        }
        // Quando esta tela for carregada
        private void TelaFecharVenda_Load(object sender, EventArgs e)
        {
            lbl_data.Text = DateTime.Now.ToString();
        }
    }
}
