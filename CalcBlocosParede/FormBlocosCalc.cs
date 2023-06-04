using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcBlocosParede
{
    public partial class FormBlocosCalc: Form
    {
        public FormBlocosCalc()
        {
            InitializeComponent();
        }

        private void blocoMedio_Click(object sender, EventArgs e)
        {
           
                if (double.TryParse(medidaLinhaReta.Text, out double linhaReta) && double.TryParse(alturaMuro.Text, out double alturaBloco))
                {
                    double areaMuro = linhaReta * alturaBloco;
                    double blocoPorMetroQuadrado = 18.5;
                    double qntdBloco = areaMuro * blocoPorMetroQuadrado;
                    txtResultado.Text = $"Quantidade de Blocos necessários: {qntdBloco}";
                };
            
        }

        private void blocoGrande_Click(object sender, EventArgs e)
        {
            if (double.TryParse(medidaLinhaReta.Text, out double linhaReta) && double.TryParse(alturaMuro.Text, out double alturaBloco))
            {
                double areaMuro = linhaReta * alturaBloco;
                double blocoPorMetroQuadrado = 13.5;
                double qntdBloco = areaMuro * blocoPorMetroQuadrado;
                txtResultado.Text = $"Quantidade de Blocos necessários: {qntdBloco}";
            };
        }
    }
}
