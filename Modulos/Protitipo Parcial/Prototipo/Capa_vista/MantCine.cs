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
    public partial class MantCine : Form
    {
        public MantCine()
        {
            InitializeComponent();
            this.navegador1.config("cines", this, "8003");
        }
    }
}
