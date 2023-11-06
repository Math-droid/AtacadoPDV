namespace AtacadoPDV.View
{
    partial class TelaFecharVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaFecharVenda));
            label1 = new Label();
            label2 = new Label();
            lbl_data = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(104, 42);
            label1.Name = "label1";
            label1.Size = new Size(166, 23);
            label1.TabIndex = 0;
            label1.Text = "Francisco Eventos LTDA ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 78);
            label2.Name = "label2";
            label2.Size = new Size(166, 15);
            label2.TabIndex = 1;
            label2.Text = "Rua da Alegria, 171 - SBC  - SP";
            // 
            // lbl_data
            // 
            lbl_data.AutoSize = true;
            lbl_data.Location = new Point(56, 146);
            lbl_data.Name = "lbl_data";
            lbl_data.Size = new Size(65, 15);
            lbl_data.TabIndex = 2;
            lbl_data.Text = "00/00/0000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(104, 111);
            label4.Name = "label4";
            label4.Size = new Size(140, 15);
            label4.TabIndex = 3;
            label4.Text = "CNPJ: 12.345.678/0001-00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(127, 146);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 4;
            label5.Text = "15674651";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(188, 146);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 5;
            label6.Text = "CCF 18946.6489";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(282, 146);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 6;
            label7.Text = "COD: 0001";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(104, 220);
            label8.Name = "label8";
            label8.Size = new Size(49, 21);
            label8.TabIndex = 7;
            label8.Text = "Total: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(170, 226);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(76, 275);
            label10.Name = "label10";
            label10.Size = new Size(201, 25);
            label10.TabIndex = 9;
            label10.Text = "Pagamento Recebido";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(179, 225);
            label11.Name = "label11";
            label11.Size = new Size(19, 15);
            label11.TabIndex = 10;
            label11.Text = "56";
            // 
            // TelaFecharVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 328);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lbl_data);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaFecharVenda";
            Text = "Fechar Venda";
            Load += TelaFecharVenda_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lbl_data;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}