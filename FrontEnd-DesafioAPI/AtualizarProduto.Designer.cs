namespace FrontEnd_DesafioAPI
{
    partial class AtualizarProduto
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
            this.NPCategoria = new System.Windows.Forms.ComboBox();
            this.NPQT = new System.Windows.Forms.NumericUpDown();
            this.NPValor = new System.Windows.Forms.NumericUpDown();
            this.aaa = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Descrição = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NPDescricao = new System.Windows.Forms.TextBox();
            this.NPNome = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NPQT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NPValor)).BeginInit();
            this.SuspendLayout();
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
            "Bebidas",
            "Roupa"});
            this.NPCategoria.Location = new System.Drawing.Point(17, 437);
            this.NPCategoria.Name = "NPCategoria";
            this.NPCategoria.Size = new System.Drawing.Size(340, 33);
            this.NPCategoria.TabIndex = 26;
            // 
            // NPQT
            // 
            this.NPQT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NPQT.Location = new System.Drawing.Point(17, 366);
            this.NPQT.Maximum = new decimal(new int[] {
            101,
            0,
            0,
            0});
            this.NPQT.Name = "NPQT";
            this.NPQT.Size = new System.Drawing.Size(340, 30);
            this.NPQT.TabIndex = 25;
            // 
            // NPValor
            // 
            this.NPValor.DecimalPlaces = 2;
            this.NPValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NPValor.Location = new System.Drawing.Point(17, 284);
            this.NPValor.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.NPValor.Name = "NPValor";
            this.NPValor.Size = new System.Drawing.Size(340, 30);
            this.NPValor.TabIndex = 24;
            // 
            // aaa
            // 
            this.aaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aaa.Location = new System.Drawing.Point(17, 473);
            this.aaa.Name = "aaa";
            this.aaa.Size = new System.Drawing.Size(245, 61);
            this.aaa.TabIndex = 23;
            this.aaa.Text = "Atualizar";
            this.aaa.UseVisualStyleBackColor = true;
            this.aaa.Click += new System.EventHandler(this.aaa_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Valor";
            // 
            // Descrição
            // 
            this.Descrição.AutoSize = true;
            this.Descrição.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descrição.Location = new System.Drawing.Point(12, 167);
            this.Descrição.Name = "Descrição";
            this.Descrição.Size = new System.Drawing.Size(108, 25);
            this.Descrição.TabIndex = 19;
            this.Descrição.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nome";
            // 
            // NPDescricao
            // 
            this.NPDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NPDescricao.Location = new System.Drawing.Point(12, 195);
            this.NPDescricao.Name = "NPDescricao";
            this.NPDescricao.Size = new System.Drawing.Size(345, 30);
            this.NPDescricao.TabIndex = 17;
            // 
            // NPNome
            // 
            this.NPNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NPNome.Location = new System.Drawing.Point(12, 117);
            this.NPNome.Name = "NPNome";
            this.NPNome.Size = new System.Drawing.Size(345, 30);
            this.NPNome.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(345, 30);
            this.textBox1.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "ID";
            // 
            // AtualizarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 547);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
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
            this.Name = "AtualizarProduto";
            this.Text = "AtualizarProduto";
            ((System.ComponentModel.ISupportInitialize)(this.NPQT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NPValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox NPCategoria;
        private System.Windows.Forms.NumericUpDown NPQT;
        private System.Windows.Forms.NumericUpDown NPValor;
        private System.Windows.Forms.Button aaa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Descrição;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NPDescricao;
        private System.Windows.Forms.TextBox NPNome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}