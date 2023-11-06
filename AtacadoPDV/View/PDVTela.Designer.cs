namespace AtacadoPDV.View
{
    partial class PDVTela
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDVTela));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            bnt_BolQj = new Button();
            bnt_pastel = new Button();
            bnt_esfiha = new Button();
            bnt_coxinha = new Button();
            groupBox2 = new GroupBox();
            bnt_refri = new Button();
            bnt_cafe = new Button();
            bnt_suco = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            txb_cod = new TextBox();
            qtd = new NumericUpDown();
            label6 = new Label();
            txb_valTo = new TextBox();
            bnt_final = new Button();
            bnt_cancel = new Button();
            grid_prod = new DataGridView();
            colum_prod = new DataGridViewTextBoxColumn();
            colum_qtde = new DataGridViewTextBoxColumn();
            colum_uni = new DataGridViewTextBoxColumn();
            colum_val = new DataGridViewTextBoxColumn();
            bnt_add = new Button();
            bnt_clear = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)qtd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grid_prod).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(334, 35);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(512, 38);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 1;
            label2.Text = "Pedidos";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bnt_BolQj);
            groupBox1.Controls.Add(bnt_pastel);
            groupBox1.Controls.Add(bnt_esfiha);
            groupBox1.Controls.Add(bnt_coxinha);
            groupBox1.Location = new Point(48, 106);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(234, 200);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Salgados";
            // 
            // bnt_BolQj
            // 
            bnt_BolQj.FlatStyle = FlatStyle.Popup;
            bnt_BolQj.Image = Properties.Resources.MicrosoftTeams_image__21_;
            bnt_BolQj.Location = new Point(128, 111);
            bnt_BolQj.Name = "bnt_BolQj";
            bnt_BolQj.Size = new Size(75, 60);
            bnt_BolQj.TabIndex = 5;
            bnt_BolQj.UseVisualStyleBackColor = true;
            bnt_BolQj.Click += bnt_BolQj_Click;
            // 
            // bnt_pastel
            // 
            bnt_pastel.FlatStyle = FlatStyle.Popup;
            bnt_pastel.Image = Properties.Resources.MicrosoftTeams_image__23_;
            bnt_pastel.Location = new Point(128, 34);
            bnt_pastel.Name = "bnt_pastel";
            bnt_pastel.Size = new Size(75, 60);
            bnt_pastel.TabIndex = 1;
            bnt_pastel.UseVisualStyleBackColor = true;
            bnt_pastel.Click += bnt_pastel_Click;
            // 
            // bnt_esfiha
            // 
            bnt_esfiha.FlatStyle = FlatStyle.Popup;
            bnt_esfiha.Image = Properties.Resources.MicrosoftTeams_image__24_;
            bnt_esfiha.Location = new Point(26, 111);
            bnt_esfiha.Name = "bnt_esfiha";
            bnt_esfiha.Size = new Size(75, 60);
            bnt_esfiha.TabIndex = 4;
            bnt_esfiha.UseVisualStyleBackColor = true;
            bnt_esfiha.Click += bnt_esfiha_Click;
            // 
            // bnt_coxinha
            // 
            bnt_coxinha.FlatStyle = FlatStyle.Popup;
            bnt_coxinha.Image = Properties.Resources.MicrosoftTeams_image__22_;
            bnt_coxinha.Location = new Point(26, 34);
            bnt_coxinha.Name = "bnt_coxinha";
            bnt_coxinha.Size = new Size(75, 60);
            bnt_coxinha.TabIndex = 0;
            bnt_coxinha.UseVisualStyleBackColor = true;
            bnt_coxinha.Click += bnt_coxinha_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bnt_refri);
            groupBox2.Controls.Add(bnt_cafe);
            groupBox2.Controls.Add(bnt_suco);
            groupBox2.Location = new Point(48, 312);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(343, 127);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bebidas";
            // 
            // bnt_refri
            // 
            bnt_refri.FlatStyle = FlatStyle.Popup;
            bnt_refri.Image = Properties.Resources.MicrosoftTeams_image__27_;
            bnt_refri.Location = new Point(233, 32);
            bnt_refri.Name = "bnt_refri";
            bnt_refri.Size = new Size(84, 68);
            bnt_refri.TabIndex = 2;
            bnt_refri.UseVisualStyleBackColor = true;
            bnt_refri.Click += bnt_refri_Click;
            // 
            // bnt_cafe
            // 
            bnt_cafe.FlatStyle = FlatStyle.Popup;
            bnt_cafe.Image = Properties.Resources.MicrosoftTeams_image__20_;
            bnt_cafe.Location = new Point(128, 32);
            bnt_cafe.Name = "bnt_cafe";
            bnt_cafe.Size = new Size(84, 68);
            bnt_cafe.TabIndex = 1;
            bnt_cafe.UseVisualStyleBackColor = true;
            bnt_cafe.Click += bnt_cafe_Click;
            // 
            // bnt_suco
            // 
            bnt_suco.FlatStyle = FlatStyle.Popup;
            bnt_suco.Image = (Image)resources.GetObject("bnt_suco.Image");
            bnt_suco.ImageAlign = ContentAlignment.TopCenter;
            bnt_suco.Location = new Point(26, 32);
            bnt_suco.Name = "bnt_suco";
            bnt_suco.Size = new Size(84, 68);
            bnt_suco.TabIndex = 0;
            bnt_suco.UseVisualStyleBackColor = true;
            bnt_suco.Click += bnt_suco_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Display", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(363, 35);
            label3.Name = "label3";
            label3.Size = new Size(143, 28);
            label3.TabIndex = 4;
            label3.Text = "Buffet Francisco";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.MicrosoftTeams_image__14_;
            pictureBox1.Location = new Point(123, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(431, 146);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 7;
            label4.Text = "Código";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(592, 147);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 8;
            label5.Text = "Qtde";
            // 
            // txb_cod
            // 
            txb_cod.Location = new Point(483, 143);
            txb_cod.Name = "txb_cod";
            txb_cod.Size = new Size(100, 23);
            txb_cod.TabIndex = 9;
            // 
            // qtd
            // 
            qtd.Location = new Point(631, 144);
            qtd.Name = "qtd";
            qtd.Size = new Size(47, 23);
            qtd.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(631, 346);
            label6.Name = "label6";
            label6.Size = new Size(82, 21);
            label6.TabIndex = 11;
            label6.Text = "Valor Total";
            // 
            // txb_valTo
            // 
            txb_valTo.BackColor = SystemColors.ScrollBar;
            txb_valTo.Location = new Point(733, 344);
            txb_valTo.Name = "txb_valTo";
            txb_valTo.Size = new Size(100, 23);
            txb_valTo.TabIndex = 12;
            txb_valTo.TextAlign = HorizontalAlignment.Right;
            // 
            // bnt_final
            // 
            bnt_final.Location = new Point(646, 436);
            bnt_final.Name = "bnt_final";
            bnt_final.Size = new Size(170, 23);
            bnt_final.TabIndex = 13;
            bnt_final.Text = "Finalizar";
            bnt_final.UseVisualStyleBackColor = true;
            bnt_final.Click += bnt_final_Click;
            // 
            // bnt_cancel
            // 
            bnt_cancel.Location = new Point(449, 436);
            bnt_cancel.Name = "bnt_cancel";
            bnt_cancel.Size = new Size(150, 24);
            bnt_cancel.TabIndex = 14;
            bnt_cancel.Text = "Cancelar";
            bnt_cancel.UseVisualStyleBackColor = true;
            bnt_cancel.Click += bnt_cancel_Click;
            // 
            // grid_prod
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grid_prod.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grid_prod.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_prod.Columns.AddRange(new DataGridViewColumn[] { colum_prod, colum_qtde, colum_uni, colum_val });
            grid_prod.EnableHeadersVisualStyles = false;
            grid_prod.GridColor = Color.WhiteSmoke;
            grid_prod.Location = new Point(428, 168);
            grid_prod.Name = "grid_prod";
            grid_prod.RowHeadersVisible = false;
            grid_prod.RowTemplate.Height = 25;
            grid_prod.Size = new Size(405, 150);
            grid_prod.TabIndex = 15;
            grid_prod.UseWaitCursor = true;
            // 
            // colum_prod
            // 
            colum_prod.HeaderText = "Produto";
            colum_prod.Name = "colum_prod";
            // 
            // colum_qtde
            // 
            colum_qtde.HeaderText = "Qtde";
            colum_qtde.Name = "colum_qtde";
            // 
            // colum_uni
            // 
            colum_uni.HeaderText = "Unitário";
            colum_uni.Name = "colum_uni";
            // 
            // colum_val
            // 
            colum_val.HeaderText = "Valor";
            colum_val.Name = "colum_val";
            // 
            // bnt_add
            // 
            bnt_add.Location = new Point(684, 142);
            bnt_add.Name = "bnt_add";
            bnt_add.Size = new Size(75, 23);
            bnt_add.TabIndex = 16;
            bnt_add.Text = "Adicionar";
            bnt_add.UseVisualStyleBackColor = true;
            bnt_add.Click += bnt_add_Click;
            // 
            // bnt_clear
            // 
            bnt_clear.Location = new Point(765, 142);
            bnt_clear.Name = "bnt_clear";
            bnt_clear.Size = new Size(75, 23);
            bnt_clear.TabIndex = 17;
            bnt_clear.Text = "Limpar";
            bnt_clear.UseVisualStyleBackColor = true;
            bnt_clear.Click += bnt_clear_Click;
            // 
            // PDVTela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(861, 472);
            Controls.Add(bnt_clear);
            Controls.Add(bnt_add);
            Controls.Add(grid_prod);
            Controls.Add(bnt_cancel);
            Controls.Add(bnt_final);
            Controls.Add(txb_valTo);
            Controls.Add(label6);
            Controls.Add(qtd);
            Controls.Add(txb_cod);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PDVTela";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela de Pedidos";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)qtd).EndInit();
            ((System.ComponentModel.ISupportInitialize)grid_prod).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Button bnt_BolQj;
        private Button bnt_pastel;
        private Button bnt_esfiha;
        private Button bnt_coxinha;
        private GroupBox groupBox2;
        private Button bnt_cafe;
        private Button bnt_suco;
        private Label label3;
        private Button bnt_refri;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
        private TextBox txb_cod;
        private NumericUpDown qtd;
        private Label label6;
        private TextBox txb_valTo;
        private Button bnt_final;
        private Button bnt_cancel;
        private Button bnt_add;
        private DataGridViewTextBoxColumn colum_prod;
        private DataGridViewTextBoxColumn colum_qtde;
        private DataGridViewTextBoxColumn colum_uni;
        private DataGridViewTextBoxColumn colum_val;
        public DataGridView grid_prod;
        private Button bnt_clear;
    }
}