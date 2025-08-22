using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BILHETERIA
{
    public partial class Form1 : Form
    {

        private System.Windows.Forms.Label faturamentoLabel;
        private System.Windows.Forms.Label titulo;
        private Button reservar;
        private Button faturamento;
        private CheckBox[][] cadeiras;

        public Form1()
        {
            InitializeComponent();
            InitializeProject();
        }

        private void InitializeProject()
        {
            titulo = new System.Windows.Forms.Label();
            titulo.Parent = this;
            titulo.Font = new Font(titulo.Font.FontFamily, 10, titulo.Font.Style);
            titulo.Text = "BILHETERIA";
            titulo.Left = (this.ClientSize.Width - titulo.Width) / 2;
            titulo.Top = 30;

            reservar = new Button();

            reservar.Click += new EventHandler(clicouNoReserva);
            reservar.Parent = this;
            reservar.Text = "RESERVAR";
            reservar.Top = 465;
            reservar.Left = 5;

            faturamentoLabel = new System.Windows.Forms.Label
            {
                Parent = this,
                AutoSize = true,
                Top = 500, // um pouco abaixo dos botões
                Left = (this.ClientSize.Width / 2) - 50,
                Text = "Faturamento: R$ 0"
            };


            faturamento = new Button();

            faturamento.Click += new EventHandler(clicouNoFaturamento);
            faturamento.Parent = this;
            faturamento.Text = "FATURAMENTO";
            faturamento.Top = 465;
            faturamento.Left = 925;
            faturamento.Width = 98;

            cadeiras = new CheckBox[15][];

            for (int i = 0; i < 15; i++)
            {
                cadeiras[i] = new CheckBox[40];

                for (int j = 0; j < 40; j++)
                {
                    cadeiras[i][j] = new CheckBox
                    {
                        Parent = this,
                        Top = (i * 25) + 60,
                        Left = (j * 25) + 30,
                        Width = 25,
                    };
                    if (j == 0)
                    {
                        System.Windows.Forms.Label indicador = new System.Windows.Forms.Label
                        {
                            Parent = this,
                            Text = (i + 1).ToString(),
                            AutoSize = true,
                            Top = (i * 25) + 63,
                            Left = 5
                        };
                    }
                }
            }
        }

        private void clicouNoFaturamento(object sender, EventArgs e)
        {
            int faturamento = 0;

            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 40; j++)
                {
                    if (!cadeiras[i][j].Enabled)
                    {
                        if (i <= 4)
                            faturamento += 50;
                        else if (i <= 9)
                            faturamento += 30;
                        else
                            faturamento += 15;
                    }
                }
            }
            faturamentoLabel.Text = $"Faturamento: R$ {faturamento}";
        }

        private void clicouNoReserva(object sender, EventArgs e)
        {
            for(int i = 0; i < 15; i++)
            {
                for(int j = 0; j < 40; j++)
                {
                    if (cadeiras[i][j].Checked)
                    {
                        cadeiras[i][j].Enabled = false;
                    }
                }
            }
        }

    }
}
