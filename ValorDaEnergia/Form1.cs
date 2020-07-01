using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ValorDaEnergia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            kWhConsumido.Text = "";
            opComercial.Checked = false;
            opIndustria.Checked = false;
            opResidencial.Checked = false;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            double valorFinal;
            double valorInserido = Convert.ToDouble(kWhConsumido.Text);
            if (kWhConsumido.Text != "")
            {
                using (StreamWriter writer = new StreamWriter("C:\\Users\\bruno\\OneDrive\\Área de Trabalho\\EnergiaEletrica.txt", true))
                {
                   

                    if (opResidencial.Checked)
                    {
                        if (valorInserido > 500)
                        {
                            valorFinal = 0.65 * valorInserido;
                            writer.WriteLine("Valores de gastos elétricos.\n");
                            writer.WriteLine("--------------------------------------------------------------\n");
                            writer.WriteLine("Tipo de instalação: Residencial\n");
                            writer.WriteLine("--------------------------------------------------------------\n");
                            writer.WriteLine("Faixa: Acima de 500\n");
                            writer.WriteLine("--------------------------------------------------------------\n");
                            writer.WriteLine("Valor: R$"+valorFinal+ ".\n");
                            writer.WriteLine("--------------------------------------------------------------\n");

                        }
                        else
                        {
                            valorFinal = 0.40 * valorInserido;
                            writer.WriteLine("Valores de gastos elétricos.\n");
                            writer.WriteLine("--------------------------------------------------------------\n");
                            writer.WriteLine("Tipo de instalação: Residencial\n");
                            writer.WriteLine("--------------------------------------------------------------\n");
                            writer.WriteLine("Faixa: Abaixo de 500\n");
                            writer.WriteLine("--------------------------------------------------------------\n");
                            writer.WriteLine("Valor: R$" + valorFinal + ".\n");
                            writer.WriteLine("--------------------------------------------------------------\n");
                        }
                    }
                    else if (opIndustria.Checked)
                    {
                        if (valorInserido > 5000)
                        {
                            valorFinal = 0.60 * valorInserido;
                            writer.WriteLine("Valores de gastos elétricos.\n");
                            writer.WriteLine("--------------------------------------------------------------\n");
                            writer.WriteLine("Tipo de instalação: Indústria\n");
                            writer.WriteLine("--------------------------------------------------------------\n");
                            writer.WriteLine("Faixa: Acima de 5000\n");
                            writer.WriteLine("--------------------------------------------------------------\n");
                            writer.WriteLine("Valor: R$" + valorFinal + ".\n");
                            writer.WriteLine("--------------------------------------------------------------\n");
                        }
                        else
                        {
                            valorFinal = 0.55 * valorInserido;
                            writer.WriteLine("Valores de gastos elétricos.\n");
                            writer.WriteLine("--------------------------------------------------------------\n");
                            writer.WriteLine("Tipo de instalação: Indústria\n");
                            writer.WriteLine("--------------------------------------------------------------\n");
                            writer.WriteLine("Faixa: Abaixo de 5000\n");
                            writer.WriteLine("--------------------------------------------------------------\n");
                            writer.WriteLine("Valor: R$" + valorFinal + ".\n");
                            writer.WriteLine("--------------------------------------------------------------\n");
                        }

                    }
                    else if (opComercial.Checked)
                    {
                        if (valorInserido > 1000)
                        {
                            valorFinal = 0.60 * valorInserido;
                            writer.WriteLine("Valores de gastos elétricos.\n");
                            writer.WriteLine("--------------------------------------------------------------\n");
                            writer.WriteLine("Tipo de instalação: Comercial\n");
                            writer.WriteLine("--------------------------------------------------------------\n");
                            writer.WriteLine("Faixa: Acima de 1000\n");
                            writer.WriteLine("--------------------------------------------------------------\n");
                            writer.WriteLine("Valor: R$" + valorFinal + ".\n");
                            writer.WriteLine("--------------------------------------------------------------\n");
                        }
                        else
                        {
                            valorFinal = 0.55 * valorInserido;
                            writer.WriteLine("Valores de gastos elétricos.\n");
                            writer.WriteLine("--------------------------------------------------------------\n");
                            writer.WriteLine("Tipo de instalação: Comercial\n");
                            writer.WriteLine("--------------------------------------------------------------\n");
                            writer.WriteLine("Faixa: Abaixo de 1000\n");
                            writer.WriteLine("--------------------------------------------------------------\n");
                            writer.WriteLine("Valor: R$" + valorFinal + ".\n");
                            writer.WriteLine("--------------------------------------------------------------\n");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Selecione um tipo de instalação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {

                MessageBox.Show("Digite uma quantia consumida de Kwh!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
                            }
        }
    }

