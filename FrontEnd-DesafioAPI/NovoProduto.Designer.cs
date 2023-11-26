namespace FrontEnd_DesafioAPI
{
    partial class NovoProduto
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
            this.NPNome = new System.Windows.Forms.TextBox();
            this.NPDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Descrição = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.aaa = new System.Windows.Forms.Button();
            this.NPValor = new System.Windows.Forms.NumericUpDown();
            this.NPQT = new System.Windows.Forms.NumericUpDown();
            this.NPCategoria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NPValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NPQT)).BeginInit();
            this.SuspendLayout();
            // 
            // NPNome
            // 
            this.NPNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NPNome.Location = new System.Drawing.Point(12, 57);
            this.NPNome.Name = "NPNome";
            this.NPNome.Size = new System.Drawing.Size(345, 30);
            this.NPNome.TabIndex = 2;
            this.NPNome.TextChanged += new System.EventHandler(this.NPNome_TextChanged);
            // 
            // NPDescricao
            // 
            this.NPDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NPDescricao.Location = new System.Drawing.Point(12, 135);
            this.NPDescricao.Name = "NPDescricao";
            this.NPDescricao.Size = new System.Drawing.Size(345, 30);
            this.NPDescricao.TabIndex = 3;
            this.NPDescricao.TextChanged += new System.EventHandler(this.NPDescricao_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Descrição
            // 
            this.Descrição.AutoSize = true;
            this.Descrição.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descrição.Location = new System.Drawing.Point(12, 107);
            this.Descrição.Name = "Descrição";
            this.Descrição.Size = new System.Drawing.Size(108, 25);
            this.Descrição.TabIndex = 8;
            this.Descrição.Text = "Descrição";
            this.Descrição.Click += new System.EventHandler(this.Descrição_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Valor";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Quantidade";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Categoria";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // aaa
            // 
            this.aaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aaa.Location = new System.Drawing.Point(17, 413);
            this.aaa.Name = "aaa";
            this.aaa.Size = new System.Drawing.Size(245, 61);
            this.aaa.TabIndex = 12;
            this.aaa.Text = "Adicionar";
            this.aaa.UseVisualStyleBackColor = true;
            this.aaa.Click += new System.EventHandler(this.button1_Click);
            // 
            // NPValor
            // 
            this.NPValor.DecimalPlaces = 2;
            this.NPValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NPValor.Location = new System.Drawing.Point(17, 224);
            this.NPValor.Name = "NPValor";
            this.NPValor.Size = new System.Drawing.Size(340, 30);
            this.NPValor.TabIndex = 13;
            this.NPValor.ValueChanged += new System.EventHandler(this.NPValor_ValueChanged);
            // 
            // NPQT
            // 
            this.NPQT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NPQT.Location = new System.Drawing.Point(17, 306);
            this.NPQT.Name = "NPQT";
            this.NPQT.Size = new System.Drawing.Size(340, 30);
            this.NPQT.TabIndex = 14;
            this.NPQT.ValueChanged += new System.EventHandler(this.NPQT_ValueChanged);
            // 
            // NPCategoria
            // 
            this.NPCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NPCategoria.FormattingEnabled = true;
            this.NPCategoria.Items.AddRange(new object[] {
            "Brinquedo",
            "Comida",
            "Limpeza",
            "Eletrodomesticos",
            "Bebidas"});
            this.NPCategoria.Location = new System.Drawing.Point(17, 377);
            this.NPCategoria.Name = "NPCategoria";
            this.NPCategoria.Size = new System.Drawing.Size(340, 33);
            this.NPCategoria.TabIndex = 15;
            this.NPCategoria.SelectedIndexChanged += new System.EventHandler(this.NPCategoria_SelectedIndexChanged);
            // 
            // NovoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 486);
            this.Controls.Add(this.NPCategoria);
            this.Controls.Add(this.NPQT);
            this.Controls.Add(this.NPValor);
            this.Controls.Add(this.aaa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Descrição);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NPDescricao);
            this.Controls.Add(this.NPNome);
            this.Name = "NovoProduto";
            this.Text = "NovoProduto";
            ((System.ComponentModel.ISupportInitialize)(this.NPValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NPQT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NPNome;
        private System.Windows.Forms.TextBox NPDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Descrição;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button aaa;
        private System.Windows.Forms.NumericUpDown NPValor;
        private System.Windows.Forms.NumericUpDown NPQT;
        private System.Windows.Forms.ComboBox NPCategoria;
    }
}