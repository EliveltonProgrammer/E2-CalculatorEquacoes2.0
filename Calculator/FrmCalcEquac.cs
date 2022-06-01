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
        double vlrA = 0, vlrB = 0, vlrC = 0, delta = 0, x1 = 0, x2 = 0, ptoMinX = 0, ptoMinY = 0, ptoMaxX = 0, ptoMaxY = 0;

        public FrmCalc()
        {
            InitializeComponent();
            LbData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cbxTpEquac.SelectedIndex = 1;
            lbinfRaiz.Visible = false;
            lbinfEquac.Visible = false;
            lbinfParab.Visible = false;
            lbInfPtoVertice.Visible = false;
            lbinfCoordVertice.Visible = false;
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


                    //Obtendo Pontos do Vértice (Minimo e Maximo x,y)
                    //Parabola voltada para cima (Ponto Minimo):
                    if (vlrA > 0)
                    {
                        ptoMinX = -vlrB / (2.0 * vlrA);
                        TbxPtoMinX.Text = ptoMinX.ToString(TbxPtoMinX.Text);

                        ptoMinY = -delta / (4.0 * vlrA);
                        TbxPtoMinY.Text = ptoMinY.ToString(TbxPtoMinY.Text);

                        TbxPtoMaxX.Text = "Inexistente";
                        TbxPtoMaxY.Text = "Inexistente";
                    }
                    //Parabola voltada para baixo (Ponto Maximo):
                    else if (vlrA < 0)
                    {
                        ptoMaxX = -vlrB / (2.0 * vlrA);
                        TbxPtoMaxX.Text = ptoMaxX.ToString(TbxPtoMaxX.Text);

                        ptoMaxY = - Math.Pow(vlrB, 2.0) - 4.0 * vlrA * vlrC;
                        TbxPtoMaxY.Text = ptoMaxY.ToString(TbxPtoMaxY.Text);

                        TbxPtoMinX.Text = "Inexistente";
                        TbxPtoMinY.Text = "Inexistente";
                    }

                    if (vlrA == 0)
                    {
                        if (MessageBox.Show("Na Equação do 2º Grau o valor de 'A' não pode ser igual = 0. Clique novamente em Calcular!", "Mensagem",
                         MessageBoxButtons.OK, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes) ;

                        vlrA = 1;
                        TbxVlrA.Text = Convert.ToString(vlrA);
                    }

                    lbinfRaiz.Visible = true;
                    lbinfParab.Visible = true;
                    lbInfPtoVertice.Visible = true;
                    lbinfCoordVertice.Visible = true;

                    if (delta == 0)
                    {
                        lbinfRaiz.Text = "Há 1 Raíz Real";
                        lbinfCoordVertice.Text = "As Coordenadas do Vértice são: (x=0;y=0)";
                    }
                    else if (delta > 0 && vlrA > 0)
                    {
                        lbinfRaiz.Text = "Há 2 Raízes Reais";
                        lbinfParab.Text = "Se A > 0: Parabola Voltada para Cima";
                        lbInfPtoVertice.Text = "Possue Vértice em Ponto Minímo";
                        lbinfCoordVertice.Text = "As Coordenadas do Vértice são: (" + ptoMinX + ";" + ptoMinY + ")";
                    }
                    else if (delta < 0)
                    {
                        lbinfRaiz.Text = "Não há Raízes Reais";
                        lbinfParab.Text = "Parabola Inexistênte";
                        lbInfPtoVertice.Text = "Ponto Minímo e Máximo Inexistênte";
                        lbinfCoordVertice.Text = "Coordenadas dos Vértices Inexistentes";
                    }
                    if (vlrA < 0)
                    {
                        lbinfParab.Text = "Se A < 0: Parabola Voltada para Baixo";
                        lbInfPtoVertice.Text = "Possue Vértice em Ponto Máximo";
                        lbinfCoordVertice.Text = "As Coordenadas do Vértice são: (" + ptoMaxX + ";" + ptoMaxY + ")";
                    }

                    lbinfEquac.Visible = true;

                    if (vlrB >= 0 && vlrC >= 0)
                        lbinfEquac.Text = vlrA + "x² + " + vlrB + "x + " + vlrC + " = 0";

                    if (vlrB >= 0 && vlrC <= 0)
                        lbinfEquac.Text = vlrA + "x² + " + vlrB + "x " + vlrC + " = 0";

                    if (vlrB <= 0 && vlrC >= 0)
                        lbinfEquac.Text = vlrA + "x² " + vlrB + "x + " + vlrC + " = 0";

                    if (vlrB <= 0 && vlrC <= 0)
                        lbinfEquac.Text = vlrA + "x² " + vlrB + "x " + vlrC + " = 0";
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
            //Variaveis
            vlrA = 0; vlrB = 0; vlrC = 0; delta = 0; x1 = 0; x2 = 0; 
            ptoMinX = 0; ptoMinY = 0; ptoMaxX = 0; ptoMaxY = 0;

            //TextBox Interface
            TbxVlrA.Text = ""; TbxVlrB.Text = ""; TbxVlrC.Text = "";
            TbxVlrDelta.Text = ""; TbxVlrX1.Text = ""; TbxVlrX2.Text = "";
            TbxPtoMinX.Text = ""; TbxPtoMinY.Text = ""; TbxPtoMaxX.Text = ""; TbxPtoMaxY.Text = "";

            //Componentes Informativos
            lbinfRaiz.Text = "";
            lbinfParab.Text = "";
            lbInfPtoVertice.Text = "";
            lbinfCoordVertice.Text = "";
            lbinfEquac.Text = "";

            lbinfRaiz.Visible = false;
            lbinfParab.Visible = false;
            lbInfPtoVertice.Visible = false;
            lbinfCoordVertice.Visible = false;
            lbinfEquac.Visible = false;
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


