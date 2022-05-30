using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcDelta
{
    public partial class FrmCalcDelta : Form
    {
        double vlrA;
        double vlrB;
        double vlrC;
        double result;

        public FrmCalcDelta()
        {
            InitializeComponent();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (TbxVlrA.Text == "" || TbxVlrB.Text == "" || TbxVlrC.Text == "")
            {
                if (MessageBox.Show("Digite todos os Valores da Equação para efetuar os Cálculos!", "Retorno",
                     MessageBoxButtons.OK, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes) ;
            }
            else
            {
                TbxResultado.Text = "";

                vlrA = Convert.ToDouble(TbxVlrA.Text);
                vlrB = Convert.ToDouble(TbxVlrB.Text);
                vlrC = Convert.ToDouble(TbxVlrC.Text);
                //result = Convert.ToDouble(TbxResultado.Text);

                result = (vlrB * vlrB) - 4 * (vlrA * vlrC);
                TbxResultado.Text = result.ToString(TbxResultado.Text);
            }
        }
        private void btnZerar_Click(object sender, EventArgs e)
        {
            vlrA = 0; vlrB = 0; vlrC = 0;
            TbxVlrA.Text = ""; TbxVlrB.Text = ""; TbxVlrC.Text = ""; TbxResultado.Text = "";
        }

        private void FrmCalc_Load(object sender, EventArgs e)
        {

        }
    }
}


