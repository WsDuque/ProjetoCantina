using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina
{
    public partial class Chamada : Form
    {
        public Chamada()
        {
            InitializeComponent();
        }

        private void Chamada_Load(object sender, EventArgs e)
        {

        }

        private void btnIrVendas_Click(object sender, EventArgs e)
        {
            Balcão balcão = new();
            Hide();
            balcão.Show();
        }
    }
}
