using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;
using ImpressaoFormula;
using Calculator;

namespace CalcEquacao
{
    public partial class FrmCalc : Form
    {
        DadosEquacionarios a, b, c, delta, x1, x2, ptoMinX, ptoMinY, ptoMaxX, ptoMaxY;
        public FrmCalc()
        {
            InitializeComponent();
            LbData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cbxTpEquac.SelectedIndex = 1;
            CalculoDesabilitado();
        }

        private void timerInicio_Tick(object sender, EventArgs e)
        {
            LbHorario.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void CalculoHabilitado()
        {
            TbxVlrDelta.Text = ""; TbxVlrX1.Text = ""; TbxVlrX2.Text = "";
            TbxPtoMinX.Text = ""; TbxPtoMinY.Text = ""; TbxPtoMaxX.Text = "";
            TbxPtoMaxY.Text = "";

            lbStatusInf.Visible = false;
            lbStatusEquac.Visible = false;

            lbinfRaiz.Visible = true;
            lbinfEquac.Visible = true;
            lbinfParab.Visible = true;
            lbInfPtoVertice.Visible = true;
            lbinfCoordVertice.Visible = true;

            TbxVlrDelta.Enabled = true;
            TbxVlrX1.Enabled = true;
            TbxVlrX2.Enabled = true;

            TbxPtoMinX.Enabled = true;
            TbxPtoMinY.Enabled = true;
            TbxPtoMaxX.Enabled = true;
            TbxPtoMaxY.Enabled = true;
        }

        private void CalculoDesabilitado()
        {
            lbStatusInf.Visible = true;
            lbStatusInf.Text = "Sem Informações até o Momento";
            lbStatusEquac.Visible = true;
            lbStatusEquac.Text = "Estrutura da Equação não Digitada";

            lbinfRaiz.Visible = false;
            lbinfEquac.Visible = false;
            lbinfParab.Visible = false;
            lbInfPtoVertice.Visible = false;
            lbinfCoordVertice.Visible = false;

            TbxVlrDelta.Enabled = false;
            TbxVlrX1.Enabled = false;
            TbxVlrX2.Enabled = false;

            TbxPtoMinX.Enabled = false;
            TbxPtoMinY.Enabled = false;
            TbxPtoMaxX.Enabled = false;
            TbxPtoMaxY.Enabled = false;
        }

        private void ImpressaoFormula()
        {
            if (TbxVlrDelta.Text == "")
            {
                if (MessageBox.Show("Impossível Imprimir a Formula Explicativa pois não há dados Calculados!", "Impressão Formula Explicativa",
                       MessageBoxButtons.OK, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes) ;
            }
            else
            {
                // Cria documento com 40 Linhas
                string[] ImpressaoFormula = new string[50];
                for (int i = 0; i < 1; i++)
                {
                    ImpressaoFormula.ToString();
                    DateTime DataHoraAtual = DateTime.Now;

                    ImpressaoFormula[i] += "             PROCEDIMENTO PARA RESOLUÇÃO DA EQUAÇÃO: " + lbinfEquac.Text;
                    ImpressaoFormula[i] += $"\n";
                    ImpressaoFormula[i] += $"\n" + "Impresso em: " + DataHoraAtual;
                    ImpressaoFormula[i] += $"\n" +"--------------------------------------------------------------------------------------------------------------------------";
                    ImpressaoFormula[i] += $"\n";
                    ImpressaoFormula[i] += $"\n" + "1º: Inicie descobrindo os Coeficientes da Equação:";
                    ImpressaoFormula[i] += $"\n" + "Para a Equação: " + lbinfEquac.Text + " os Coeficientes são Determinados por:";
                    ImpressaoFormula[i] += $"\n";
                    ImpressaoFormula[i] += $"\n" + "a = " + a.A;
                    ImpressaoFormula[i] += $"\n" + "b = " + b.B;
                    ImpressaoFormula[i] += $"\n" + "c = " + c.C;
                    ImpressaoFormula[i] += $"\n";
                    ImpressaoFormula[i] += $"\n" + "--------------------------------------------------------------------------------------------------------------------------";
                    ImpressaoFormula[i] += $"\n";
                    ImpressaoFormula[i] += $"\n" + "2º: Calcule o valor do Delta que será o Determinante inicial para descobrir as";
                    ImpressaoFormula[i] += $"\n" + "Raízes da Equação: " + lbinfEquac.Text + ". A Formula para Calcular o Delta é: Δ = b²-4.a.c";
                    ImpressaoFormula[i] += $"\n";
                    ImpressaoFormula[i] += $"\n" + "Substituindo os valores na Formula:";
                    ImpressaoFormula[i] += $"\n"; 
                    ImpressaoFormula[i] += $"\n" + "Δ = b²-4.a.c   ou   Δ = b²-4 x a x c";
                    ImpressaoFormula[i] += $"\n";
                    ImpressaoFormula[i] += $"\n" + "Δ = "+b.B+"²"+" -4 x "+a.A+" x "+c.C;
                    ImpressaoFormula[i] += $"\n" + "b² É o mesmo que b x b, ou seja, " + b.B +" x "+b.B+" = " + Math.Pow(b.B,2.0);
                    ImpressaoFormula[i] += $"\n";
                    ImpressaoFormula[i] += $"\n" + "Então teremos: ("+Math.Pow(b.B, 2.0) +") - 4 x "+a.A+ " x "+c.C ;
                    ImpressaoFormula[i] += $"\n";
                    ImpressaoFormula[i] += $"\n" + "Calcule Primeiro sempre o que estiver na Sequencia dentro dos Parentêses:";
                    ImpressaoFormula[i] += $"\n" + "(-4 x " + a.A + " x " + c.C + ") = " + (-4 * a.A * c.C);
                    ImpressaoFormula[i] += $"\n";
                    ImpressaoFormula[i] += $"\n" + "Logo:";
                    if (b.B >= 0)
                    {
                        ImpressaoFormula[i] += $"\n" + (-4 * a.A * c.C) + " + " + Math.Pow(b.B, 2.0) + " = " + delta.D;
                    }
                    else
                    {
                        ImpressaoFormula[i] += $"\n" + (-4 * a.A * c.C) + " - " + Math.Pow(b.B, 2.0) + " = " + delta.D;
                    }
                    ImpressaoFormula[i] += $"\n";
                    ImpressaoFormula[i] += $"\n" + "Logo o Valor de Delta é igual a:";
                    ImpressaoFormula[i] += $"\n";
                    ImpressaoFormula[i] += $"\n" + "Δ = "+delta.D;
                    ImpressaoFormula[i] += $"\n";
                    ImpressaoFormula[i] += $"\n" + "--------------------------------------------------------------------------------------------------------------------------";
                }

                PrintDocument doc = new RelImprFormula(ImpressaoFormula);
                doc.PrintPage += this.Doc_PrintPage;

                PrintDialog dialogo = new PrintDialog();
                dialogo.Document = doc;

                if (MessageBox.Show("Deseja Visualizar a Formula/Equação Explicativa antes de Imprimir?", "Impressão Formula Explicativa",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    PrintPreviewDialog ppdlg = new PrintPreviewDialog();
                    ppdlg.Document = doc;
                    ppdlg.ShowDialog();
                }
                else if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    dialogo.PrinterSettings.PrintFileName = "Configuração de Backup Base de Dados";
                    doc.Print();
                }
            }
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Recupera o documento que enviou este evento.
            RelImprFormula doc = (RelImprFormula)sender;

            // Define a fonte e determina a altura da linha
            using (Font fonte = new Font("Arial", 11))
            {
                float alturaLinha = fonte.GetHeight(e.Graphics);

                // Cria as variáveis para tratar a posição na página
                float x = e.MarginBounds.Left;
                float y = e.MarginBounds.Top;

                // Incrementa o contador de página para refletir 
                // a página que esta sendo impressa
                doc.NumeroPagina += 1;

                // Imprime toda a informação que cabe na página
                // O laço termina quando a próxima linha 
                // iria passar a borda da margem ou quando não 
                // houve mais linhas a imprimir
                while ((y + alturaLinha) < e.MarginBounds.Bottom &&
                  doc.Offset <= doc.Texto.GetUpperBound(0))
                {
                    e.Graphics.DrawString(doc.Texto[doc.Offset], fonte,
                      Brushes.Black, x, y);

                    // move para a proxima linha
                    doc.Offset += 1;

                    // Move uma linha para baixo (proxima linha)
                    y += alturaLinha;
                }

                if (doc.Offset < doc.Texto.GetUpperBound(0))
                {
                    // Havendo ainda pelo menos mais uma página.
                    // Sinaliza o evento para disparar novamente
                    e.HasMorePages = true;
                }
                else
                {
                    // A impressão terminou
                    doc.Offset = 0;
                }
            }
        }

        private void TbxVlrA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void TbxVlrB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void TbxVlrC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
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
                    if (MessageBox.Show("Digite todos os Valores da Equação para Efetuar os Calculos!", "Mensagem",
                         MessageBoxButtons.OK, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes) ;
                }
                else
                {
                    a = new DadosEquacionarios();
                    b = new DadosEquacionarios();
                    c = new DadosEquacionarios();
                    delta = new DadosEquacionarios(); // Delta = 'D' da Classe
                    x1 = new DadosEquacionarios();
                    x2 = new DadosEquacionarios();
                    ptoMinX = new DadosEquacionarios();
                    ptoMinY = new DadosEquacionarios();
                    ptoMaxX = new DadosEquacionarios();
                    ptoMaxY = new DadosEquacionarios();

                    CalculoHabilitado();                 

                    a.A = Convert.ToDouble(TbxVlrA.Text);
                    b.B = Convert.ToDouble(TbxVlrB.Text);
                    c.C = Convert.ToDouble(TbxVlrC.Text);

                    //Formula Delta:
                    delta.D = Math.Pow(b.B, 2.0) - 4 * a.A * c.C;
                    TbxVlrDelta.Text = delta.D.ToString(TbxVlrDelta.Text);

                    //Extraindo Raizes da Equação x1 e x2:
                    x1.XRaiz1 = (-b.B + Math.Sqrt(delta.D)) / (2.0 * a.A);
                    TbxVlrX1.Text = x1.XRaiz1.ToString(TbxVlrX1.Text);

                    x2.XRaiz2 = (-b.B - Math.Sqrt(delta.D)) / (2.0 * a.A);
                    TbxVlrX2.Text = x2.XRaiz2.ToString(TbxVlrX2.Text);


                    //Obtendo Pontos do Vértice (Minimo e Maximo x,y)
                    //Parabola voltada para cima (Ponto Minímo):
                    if (a.A > 0)
                    {
                        ptoMinX.VerticeMinX = -b.B / (2.0 * a.A);
                        TbxPtoMinX.Text = ptoMinX.VerticeMinX.ToString(TbxPtoMinX.Text);

                        ptoMinY.VerticeMinY = - delta.D / (4.0 * a.A);
                        TbxPtoMinY.Text = ptoMinY.VerticeMinY.ToString(TbxPtoMinY.Text);

                        TbxPtoMaxX.Text = "Inexistente";
                        TbxPtoMaxY.Text = "Inexistente";
                    }
                    //Parabola voltada para baixo (Ponto Máximo):
                    else if (a.A < 0)
                    {
                        ptoMaxX.VerticeMaxX = -b.B / (2.0 * a.A);
                        TbxPtoMaxX.Text = ptoMaxX.VerticeMaxX.ToString(TbxPtoMaxX.Text);

                        ptoMaxY.VerticeMaxY = -Math.Pow(b.B, 2.0) - 4.0 * a.A * c.C;
                        TbxPtoMaxY.Text = ptoMaxY.VerticeMaxY.ToString(TbxPtoMaxY.Text);

                        TbxPtoMinX.Text = "Inexistente";
                        TbxPtoMinY.Text = "Inexistente";
                    }

                    if (a.A == 0)
                    {
                        if (MessageBox.Show("Na Equação do 2º Grau o valor de 'A' não pode ser igual = 0. Clique novamente em Calcular!", "Mensagem",
                         MessageBoxButtons.OK, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes) ;

                        a.A = 1;
                        TbxVlrA.Text = Convert.ToString(a.A);
                    }

                    if (delta.D == 0)
                    {
                        lbinfRaiz.Text = "Há 1 Raíz Real";
                        lbinfParab.Text = "Parabola Voltada para Baixo";
                        lbInfPtoVertice.Text = "Possue Vértice em Ponto Minímo = 0";
                        lbinfCoordVertice.Text = "As Coordenadas do Vértice são: (x=0;y=0)";
                    }
                    else if (delta.D > 0 && a.A > 0)
                    {
                        lbinfRaiz.Text = "Há 2 Raízes Reais";
                        lbinfParab.Text = "Se A > 0: Parabola Voltada para Cima";
                        lbInfPtoVertice.Text = "Possue Vértice em Ponto Minímo";
                        lbinfCoordVertice.Text = "As Coordenadas do Vértice são: (x=" + ptoMinX + ";y=" + ptoMinY + ")";
                    }
                    else if (delta.D < 0)
                    {
                        lbinfRaiz.Text = "Não há Raízes Reais";
                        lbinfParab.Text = "Parabola Inexistente";
                        lbInfPtoVertice.Text = "Ponto Minímo e Máximo Inexistente";
                        lbinfCoordVertice.Text = "Coordenadas dos Vértices Inexistentes";
                        TbxVlrX1.Text = "Inexistente";
                        TbxVlrX2.Text = "Inexistente";
                        TbxPtoMinX.Text = "Inexistente";
                        TbxPtoMinY.Text = "Inexistente";
                    }
                    if (a.A < 0)
                    {
                        lbinfParab.Text = "Se A < 0: Parabola Voltada para Baixo";
                        lbInfPtoVertice.Text = "Possue Vértice em Ponto Máximo";
                        lbinfCoordVertice.Text = "As Coordenadas do Vértice são: (x=" + ptoMaxX + ";y=" + ptoMaxY + ")";
                    }

                    if (b.B >= 0 && c.C >= 0)
                        lbinfEquac.Text = a.A + "x² + " + b.B + "x + " + c.C + " = 0";

                    if (b.B >= 0 && c.C <= 0)
                        lbinfEquac.Text = a.A + "x² + " + b.B + "x " + c.C + " = 0";

                    if (b.B <= 0 && c.C >= 0)
                        lbinfEquac.Text = a.A + "x² " + b.B + "x + " + c.C + " = 0";

                    if (b.B <= 0 && c.C <= 0)
                        lbinfEquac.Text = a.A + "x² " + b.B + "x " + c.C + " = 0";

                    if (a.A >= 0 && b.B >= 0 && c.C >= 0)
                        lbinfEquac.Text = a.A + "x² + " + b.B + "x + " + c.C + " = 0";
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
            a.A = 0; b.B = 0; c.C = 0; delta.D = 0; x1.XRaiz1 = 0; x2.XRaiz2 = 0;
            ptoMinX.VerticeMinX = 0; ptoMinY.VerticeMinY = 0; ptoMaxX.VerticeMaxX = 0; ptoMaxY.VerticeMaxY = 0;

            //TextBox Interface
            TbxVlrA.Text = ""; TbxVlrB.Text = ""; TbxVlrC.Text = "";
            TbxVlrDelta.Text = ""; TbxVlrX1.Text = ""; TbxVlrX2.Text = "";
            TbxPtoMinX.Text = ""; TbxPtoMinY.Text = ""; TbxPtoMaxX.Text = ""; TbxPtoMaxY.Text = "";

            //Componentes Informativos
            lbinfRaiz.Text = ""; lbinfParab.Text = ""; lbInfPtoVertice.Text = "";
            lbinfCoordVertice.Text = ""; lbinfEquac.Text = "";

            CalculoDesabilitado();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularEquac2grau();
        }
        private void btnZerar_Click(object sender, EventArgs e)
        {
            CalculoDesabilitado();
            ZerarCalculo();
        }
        private void btnImprFormula_Click(object sender, EventArgs e)
        {
            ImpressaoFormula();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}


