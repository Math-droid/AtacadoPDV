namespace AtacadoPDV.View
{
    partial class LoginTela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginTela));
            label2 = new Label();
            label3 = new Label();
            btn_acess = new Button();
            txt_User = new TextBox();
            txt_Senha = new TextBox();
            label1 = new Label();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(437, 53);
            label2.Name = "label2";
            label2.Size = new Size(114, 37);
            label2.TabIndex = 1;
            label2.Text = "Usuário:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(447, 99);
            label3.Name = "label3";
            label3.Size = new Size(95, 37);
            label3.TabIndex = 2;
            label3.Text = "Senha:";
            // 
            // btn_acess
            // 
            btn_acess.Location = new Point(456, 172);
            btn_acess.Name = "btn_acess";
            btn_acess.Size = new Size(228, 47);
            btn_acess.TabIndex = 3;
            btn_acess.Text = "Acessar";
            btn_acess.UseVisualStyleBackColor = true;
            btn_acess.Click += btn_acess_Click;
            // 
            // txt_User
            // 
            txt_User.Location = new Point(564, 67);
            txt_User.Name = "txt_User";
            txt_User.Size = new Size(120, 23);
            txt_User.TabIndex = 4;
            txt_User.Text = "admin";
            // 
            // txt_Senha
            // 
            txt_Senha.Location = new Point(564, 114);
            txt_Senha.Name = "txt_Senha";
            txt_Senha.PasswordChar = '*';
            txt_Senha.Size = new Size(120, 23);
            txt_Senha.TabIndex = 5;
            txt_Senha.Text = "123";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(437, 53);
            label1.Name = "label1";
            label1.Size = new Size(114, 37);
            label1.TabIndex = 1;
            label1.Text = "Usuário:";
            // 
            // button2
            // 
            button2.Location = new Point(620, 279);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Sair";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(22, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(395, 290);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // LoginTela
            // 
            AcceptButton = btn_acess;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 329);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(txt_Senha);
            Controls.Add(txt_User);
            Controls.Add(btn_acess);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginTela";
            Text = "Login Buffet";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private Button btn_acess;
        private TextBox txt_User;
        private TextBox txt_Senha;
        private Label label1;
        private Button button2;
        private PictureBox pictureBox1;
    }
}