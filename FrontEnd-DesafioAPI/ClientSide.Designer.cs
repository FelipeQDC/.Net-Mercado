namespace FrontEnd_DesafioAPI
{
    partial class ClientSide
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
            this.TextoInicial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextoInicial
            // 
            this.TextoInicial.AutoSize = true;
            this.TextoInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoInicial.Location = new System.Drawing.Point(12, 9);
            this.TextoInicial.Name = "TextoInicial";
            this.TextoInicial.Size = new System.Drawing.Size(96, 29);
            this.TextoInicial.TabIndex = 1;
            this.TextoInicial.Text = "Cliente";
            // 
            // ClientSide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextoInicial);
            this.Name = "ClientSide";
            this.Text = "ClientSide";
            this.Load += new System.EventHandler(this.ClientSide_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextoInicial;
    }
}