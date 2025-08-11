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
    public partial class formAdcEstoque : Form
    {
        public string NomeItem { get; private set; }
        public int Quantidade { get; private set; }
        public decimal Preco { get; private set; }

        public formAdcEstoque()
        {
            InitializeComponent();
        }


    }
}
