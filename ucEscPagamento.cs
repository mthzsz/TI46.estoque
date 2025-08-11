using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI46.estoque._0._1
{
    public partial class ucEscPagamento : UserControl
    {
        public ucEscPagamento()
        {
            InitializeComponent();
            btnCartao.FlatAppearance.BorderSize = 0;
            btnDinheiro.FlatAppearance.BorderSize = 0;
            btnPix.FlatAppearance.BorderSize = 0;
        }
    }
}
