using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista_PrototipoMenu
{
    public partial class Ejemplo : Form
    {
        public Ejemplo()
        {
            InitializeComponent();
            this.navegador1.config("ejemplo", this, "Ejemplo2");
        }
    }
}
