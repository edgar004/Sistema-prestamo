using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilidades
{
    public partial class TxtBoxError : TextBox
    {
        public TxtBoxError()    
        {
            InitializeComponent();
        }

        public Boolean Validar { set; get; }

        private void TxtBoxError_Load(object sender, EventArgs e)
        {

        }
    }
}
