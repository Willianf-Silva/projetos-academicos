namespace agenSystem
{
    partial class frm_loginMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_loginMenu));
            this.txtUsuarioLogin = new System.Windows.Forms.TextBox();
            this.txtSenhaLogin = new System.Windows.Forms.TextBox();
            this.lblUsuarioLogin = new System.Windows.Forms.Label();
            this.lblSenhaLogin = new System.Windows.Forms.Label();
            this.btLogar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btEsqueceuSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsuarioLogin
            // 
            this.txtUsuarioLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioLogin.Location = new System.Drawing.Point(107, 134);
            this.txtUsuarioLogin.Name = "txtUsuarioLogin";
            this.txtUsuarioLogin.Size = new System.Drawing.Size(194, 26);
            this.txtUsuarioLogin.TabIndex = 0;
            // 
            // txtSenhaLogin
            // 
            this.txtSenhaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaLogin.Location = new System.Drawing.Point(107, 160);
            this.txtSenhaLogin.Name = "txtSenhaLogin";
            this.txtSenhaLogin.PasswordChar = '*';
            this.txtSenhaLogin.Size = new System.Drawing.Size(194, 26);
            this.txtSenhaLogin.TabIndex = 1;
            // 
            // lblUsuarioLogin
            // 
            this.lblUsuarioLogin.AutoSize = true;
            this.lblUsuarioLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogin.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioLogin.Location = new System.Drawing.Point(37, 137);
            this.lblUsuarioLogin.Name = "lblUsuarioLogin";
            this.lblUsuarioLogin.Size = new System.Drawing.Size(64, 20);
            this.lblUsuarioLogin.TabIndex = 2;
            this.lblUsuarioLogin.Text = "Usuário";
            // 
            // lblSenhaLogin
            // 
            this.lblSenhaLogin.AutoSize = true;
            this.lblSenhaLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblSenhaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaLogin.ForeColor = System.Drawing.Color.White;
            this.lblSenhaLogin.Location = new System.Drawing.Point(37, 163);
            this.lblSenhaLogin.Name = "lblSenhaLogin";
            this.lblSenhaLogin.Size = new System.Drawing.Size(56, 20);
            this.lblSenhaLogin.TabIndex = 3;
            this.lblSenhaLogin.Text = "Senha";
            // 
            // btLogar
            // 
            this.btLogar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btLogar.BackgroundImage")));
            this.btLogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btLogar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogar.ForeColor = System.Drawing.Color.White;
            this.btLogar.Location = new System.Drawing.Point(41, 198);
            this.btLogar.Name = "btLogar";
            this.btLogar.Size = new System.Drawing.Size(127, 30);
            this.btLogar.TabIndex = 4;
            this.btLogar.Text = "Entrar";
            this.btLogar.UseVisualStyleBackColor = true;
            this.btLogar.Click += new System.EventHandler(this.btLogar_Click);
            // 
            // btSair
            // 
            this.btSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSair.BackgroundImage")));
            this.btSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.ForeColor = System.Drawing.Color.White;
            this.btSair.Location = new System.Drawing.Point(174, 198);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(127, 30);
            this.btSair.TabIndex = 5;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btEsqueceuSenha
            // 
            this.btEsqueceuSenha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btEsqueceuSenha.BackgroundImage")));
            this.btEsqueceuSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEsqueceuSenha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btEsqueceuSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEsqueceuSenha.ForeColor = System.Drawing.Color.White;
            this.btEsqueceuSenha.Location = new System.Drawing.Point(41, 238);
            this.btEsqueceuSenha.Name = "btEsqueceuSenha";
            this.btEsqueceuSenha.Size = new System.Drawing.Size(260, 30);
            this.btEsqueceuSenha.TabIndex = 6;
            this.btEsqueceuSenha.Text = "Recuperar Usuário";
            this.btEsqueceuSenha.UseVisualStyleBackColor = true;
            this.btEsqueceuSenha.Click += new System.EventHandler(this.btEsqueceuSenha_Click);
            // 
            // frm_loginMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(350, 300);
            this.Controls.Add(this.btEsqueceuSenha);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btLogar);
            this.Controls.Add(this.lblSenhaLogin);
            this.Controls.Add(this.lblUsuarioLogin);
            this.Controls.Add(this.txtSenhaLogin);
            this.Controls.Add(this.txtUsuarioLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_loginMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuarioLogin;
        private System.Windows.Forms.TextBox txtSenhaLogin;
        private System.Windows.Forms.Label lblUsuarioLogin;
        private System.Windows.Forms.Label lblSenhaLogin;
        private System.Windows.Forms.Button btLogar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btEsqueceuSenha;
    }
}