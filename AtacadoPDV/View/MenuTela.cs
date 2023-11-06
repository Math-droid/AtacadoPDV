﻿using System;
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
    public partial class MenuTela : Form
    {
        public MenuTela()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void selecionarTudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //Instanciando a PDVTela

            //tipo    objeto         classe
            PDVTela pDVTela = new PDVTela();
            //mostra a tela PDVTela 
            // pDVTela é um objeto
            pDVTela.Show();

        }
    }
}
