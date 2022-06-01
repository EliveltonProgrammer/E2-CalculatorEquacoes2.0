using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcEquacao
{
    public partial class FrmCalc : Form
    {
        double vlrA = 0, vlrB = 0, vlrC = 0, delta = 0, x1 = 0, x2 = 0;

        public FrmCalc()
        {
            InitializeComponent();
            LbData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cbxTpEquac.SelectedIndex = 1;
            groupInfRaiz.Visible = false;
            groupInfEquac.Visible = false;
            lbinfRaiz.Visible = false;
            lbinfEquac.Visible = false;
            lbinfParab.Visible = false;
        }

        private void timerInicio_Tick(object sender, EventArgs e)
        {
            LbHorario.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = true;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void CalcularEquac2grau()
        {
            try
            {
                if (TbxVlrA.Text == "" || TbxVlrB.Text == "" || TbxVlrC.Text == "")
                {
                    if (MessageBox.Show("Digite Todos os Valores da Equação do 2º Grau para Efetuar os calculos!", "Mensagem",
                         MessageBoxButtons.OK, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes) ;
                }
                else
                {
                    TbxVlrDelta.Text = "";
                    TbxVlrX1.Text = "";
                    TbxVlrX2.Text = "";

                    vlrA = Convert.ToDouble(TbxVlrA.Text);
                    vlrB = Convert.ToDouble(TbxVlrB.Text);
                    vlrC = Convert.ToDouble(TbxVlrC.Text);

                    //Calculando o Delta:
                    delta = Math.Pow(vlrB, 2.0) - 4 * vlrA * vlrC;
                    TbxVlrDelta.Text = delta.ToString(TbxVlrDelta.Text);

                    //Extraindo Raizes da Equação x1 e x2:
                    x1 = (-vlrB + Math.Sqrt(delta)) / (2.0 * vlrA);
                    TbxVlrX1.Text = x1.ToString(TbxVlrX1.Text);

                    x2 = (-vlrB - Math.Sqrt(delta)) / (2.0 * vlrA);
                    TbxVlrX2.Text = x2.ToString(TbxVlrX2.Text);

                    if (vlrA == 0)
                    {
                        if (MessageBox.Show("Na Equação do 2º Grau o valor de 'A' não pode ser igual = 0. Clique novamente em Calcular!", "Mensagem",
                         MessageBoxButtons.OK, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes) ;

                        vlrA = 1;
                        TbxVlrA.Text = Convert.ToString(vlrA);
                    }

                    lbinfRaiz.Visible = true;
                    lbinfParab.Visible = true;
                    groupInfRaiz.Visible = true;

                    if (delta == 0)
                    {
                        lbinfRaiz.Text = "Há 1 Raíz real";
                    }
                    else if (delta > 0 && vlrA > 0)
                    {
                        lbinfRaiz.Text = "Há 2 Raízes reais";
                        lbinfParab.Text = "se A > 0: Parabola voltada para cima";
                        lbInfPtoMin.Text = "Resultados possuem Ponto Minímo";
                    }
                    else if (delta < 0)
                    {
                        lbinfRaiz.Text = "Não Há Raízes reais";
                        lbinfParab.Text = "Parabola inexistênte";
                        lbInfPtoMin.Text = "Ponto Minímo inexistênte";
                    }

                    lbinfEquac.Visible = true;
                    groupInfEquac.Visible = true;

                    if (vlrB >= 0 && vlrC >= 0)
                        lbinfEquac.Text = vlrA + "x²+" + vlrB + "x+" + vlrC + " = 0";

                    if (vlrB >= 0 && vlrC <= 0)
                        lbinfEquac.Text = vlrA + "x²+" + vlrB + "x" + vlrC + " = 0";

                    if (vlrB <= 0 && vlrC >= 0)
                        lbinfEquac.Text = vlrA + "x²" + vlrB + "x+" + vlrC + " = 0";

                    if (vlrB <= 0 && vlrC <= 0)
                        lbinfEquac.Text = vlrA + "x²" + vlrB + "x" + vlrC + " = 0";
                    {

                    }
                }
            }
            catch
            {

            }
        }
        private void ZerarCalculo()
        {
            vlrA = 0; vlrB = 0; vlrC = 0; delta = 0; x1 = 0; x2 = 0;
            TbxVlrA.Text = ""; TbxVlrB.Text = ""; TbxVlrC.Text = "";
            TbxVlrDelta.Text = ""; TbxVlrX1.Text = ""; TbxVlrX2.Text = "";

            lbinfRaiz.Text = "";
            lbinfParab.Text = "";
            lbinfRaiz.Visible = false;
            groupInfRaiz.Visible = false;
            lbinfParab.Visible = false;

            lbinfEquac.Text = "";
            lbinfEquac.Visible = false;
            groupInfEquac.Visible = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularEquac2grau();
        }
        private void btnZerar_Click(object sender, EventArgs e)
        {
            ZerarCalculo();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}


