using System.Drawing.Printing;

namespace ImpressaoFormula
{
    public class RelImprFormula : PrintDocument
    {
        private string[] texto;
        private int numeroPagina;
        private int offset;

        public string[] Texto
        {
            get { return texto; }
            set { texto = value; }
            
        }

        public int NumeroPagina
        {
            get { return numeroPagina; }
            set { numeroPagina = value; }
        }

        public int Offset
        {
            get { return offset; }
            set { offset = value; }
        }

        public RelImprFormula(string[] _texto)
        {
            this.Texto = _texto;
        }

        private void InitializeComponent()
        {

        }
    }
}
