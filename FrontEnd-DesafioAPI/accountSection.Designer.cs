namespace FrontEnd_DesafioAPI
{
    partial class accountSection
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
            this.Accounttab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CadastroNome = new System.Windows.Forms.TextBox();
            this.CadastroEmail = new System.Windows.Forms.TextBox();
            this.CadastroSenha = new System.Windows.Forms.TextBox();
            this.LoginEmail = new System.Windows.Forms.TextBox();
            this.LoginPassword = new System.Windows.Forms.TextBox();
            this.BTNcadastro = new System.Windows.Forms.Button();
            this.BTNlogin = new System.Windows.Forms.Button();
            this.Accounttab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Accounttab
            // 
            this.Accounttab.Controls.Add(this.tabPage1);
            this.Accounttab.Controls.Add(this.tabPage2);
            this.Accounttab.Location = new System.Drawing.Point(36, 33);
            this.Accounttab.Name = "Accounttab";
            this.Accounttab.SelectedIndex = 0;
            this.Accounttab.Size = new System.Drawing.Size(322, 360);
            this.Accounttab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BTNcadastro);
            this.tabPage1.Controls.Add(this.CadastroSenha);
            this.tabPage1.Controls.Add(this.CadastroEmail);
            this.tabPage1.Controls.Add(this.CadastroNome);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(314, 331);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastrar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BTNlogin);
            this.tabPage2.Controls.Add(this.LoginPassword);
            this.tabPage2.Controls.Add(this.LoginEmail);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(314, 331);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Login";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CadastroNome
            // 
            this.CadastroNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastroNome.Location = new System.Drawing.Point(28, 30);
            this.CadastroNome.Name = "CadastroNome";
            this.CadastroNome.Size = new System.Drawing.Size(245, 30);
            this.CadastroNome.TabIndex = 0;
            // 
            // CadastroEmail
            // 
            this.CadastroEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastroEmail.Location = new System.Drawing.Point(28, 120);
            this.CadastroEmail.Name = "CadastroEmail";
            this.CadastroEmail.Size = new System.Drawing.Size(245, 30);
            this.CadastroEmail.TabIndex = 1;
            // 
            // CadastroSenha
            // 
            this.CadastroSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastroSenha.Location = new System.Drawing.Point(28, 216);
            this.CadastroSenha.Name = "CadastroSenha";
            this.CadastroSenha.Size = new System.Drawing.Size(245, 30);
            this.CadastroSenha.TabIndex = 2;
            // 
            // LoginEmail
            // 
            this.LoginEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginEmail.Location = new System.Drawing.Point(32, 41);
            this.LoginEmail.Name = "LoginEmail";
            this.LoginEmail.Size = new System.Drawing.Size(245, 30);
            this.LoginEmail.TabIndex = 1;
            // 
            // LoginPassword
            // 
            this.LoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPassword.Location = new System.Drawing.Point(32, 141);
            this.LoginPassword.Name = "LoginPassword";
            this.LoginPassword.Size = new System.Drawing.Size(245, 30);
            this.LoginPassword.TabIndex = 2;
            // 
            // BTNcadastro
            // 
            this.BTNcadastro.Location = new System.Drawing.Point(28, 282);
            this.BTNcadastro.Name = "BTNcadastro";
            this.BTNcadastro.Size = new System.Drawing.Size(245, 28);
            this.BTNcadastro.TabIndex = 3;
            this.BTNcadastro.Text = "Cadastrar";
            this.BTNcadastro.UseVisualStyleBackColor = true;
            this.BTNcadastro.Click += new System.EventHandler(this.BTNcadastro_Click);
            // 
            // BTNlogin
            // 
            this.BTNlogin.Location = new System.Drawing.Point(32, 259);
            this.BTNlogin.Name = "BTNlogin";
            this.BTNlogin.Size = new System.Drawing.Size(245, 28);
            this.BTNlogin.TabIndex = 4;
            this.BTNlogin.Text = "Login";
            this.BTNlogin.UseVisualStyleBackColor = true;
            this.BTNlogin.Click += new System.EventHandler(this.BTNlogin_Click);
            // 
            // accountSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 450);
            this.Controls.Add(this.Accounttab);
            this.Name = "accountSection";
            this.Text = "accountSection";
            this.Accounttab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Accounttab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BTNcadastro;
        private System.Windows.Forms.TextBox CadastroSenha;
        private System.Windows.Forms.TextBox CadastroEmail;
        private System.Windows.Forms.TextBox CadastroNome;
        private System.Windows.Forms.Button BTNlogin;
        private System.Windows.Forms.TextBox LoginPassword;
        private System.Windows.Forms.TextBox LoginEmail;
    }
}