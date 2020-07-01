namespace ValorDaEnergia
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.kWhConsumido = new System.Windows.Forms.TextBox();
            this.opResidencial = new System.Windows.Forms.RadioButton();
            this.opIndustria = new System.Windows.Forms.RadioButton();
            this.opComercial = new System.Windows.Forms.RadioButton();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade de kWh consumida:";
            // 
            // kWhConsumido
            // 
            this.kWhConsumido.Location = new System.Drawing.Point(172, 24);
            this.kWhConsumido.Name = "kWhConsumido";
            this.kWhConsumido.Size = new System.Drawing.Size(100, 20);
            this.kWhConsumido.TabIndex = 1;
            // 
            // opResidencial
            // 
            this.opResidencial.AutoSize = true;
            this.opResidencial.Location = new System.Drawing.Point(76, 89);
            this.opResidencial.Name = "opResidencial";
            this.opResidencial.Size = new System.Drawing.Size(33, 17);
            this.opResidencial.TabIndex = 2;
            this.opResidencial.TabStop = true;
            this.opResidencial.Text = "R";
            this.opResidencial.UseVisualStyleBackColor = true;
            // 
            // opIndustria
            // 
            this.opIndustria.AutoSize = true;
            this.opIndustria.Location = new System.Drawing.Point(167, 89);
            this.opIndustria.Name = "opIndustria";
            this.opIndustria.Size = new System.Drawing.Size(28, 17);
            this.opIndustria.TabIndex = 3;
            this.opIndustria.TabStop = true;
            this.opIndustria.Text = "I";
            this.opIndustria.UseVisualStyleBackColor = true;
            // 
            // opComercial
            // 
            this.opComercial.AutoSize = true;
            this.opComercial.Location = new System.Drawing.Point(258, 89);
            this.opComercial.Name = "opComercial";
            this.opComercial.Size = new System.Drawing.Size(32, 17);
            this.opComercial.TabIndex = 4;
            this.opComercial.TabStop = true;
            this.opComercial.Text = "C";
            this.opComercial.UseVisualStyleBackColor = true;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(12, 137);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 5;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(144, 137);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 6;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tipo de Instalação:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Comercial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Indústria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Residencial";
            // 
            // btInfo
            // 
            this.btInfo.Location = new System.Drawing.Point(256, 137);
            this.btInfo.Name = "btInfo";
            this.btInfo.Size = new System.Drawing.Size(125, 23);
            this.btInfo.TabIndex = 11;
            this.btInfo.Text = "Informativo de Valores";
            this.btInfo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 172);
            this.Controls.Add(this.btInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.opComercial);
            this.Controls.Add(this.opIndustria);
            this.Controls.Add(this.opResidencial);
            this.Controls.Add(this.kWhConsumido);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Valor da conta de energia elétrica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kWhConsumido;
        private System.Windows.Forms.RadioButton opResidencial;
        private System.Windows.Forms.RadioButton opIndustria;
        private System.Windows.Forms.RadioButton opComercial;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btInfo;
    }
}

