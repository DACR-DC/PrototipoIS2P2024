using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo_PrototipoMenu;

namespace Controlador_PrototipoMenu
{
    public class Controlador
    {
        Sentencias sn = new Sentencias();
        public void InsertarMoneda(string nombre_moneda, int moneda_valor)
        {
            sn.InsertarMoneda(nombre_moneda, moneda_valor);
        }
        public void BorrarMoneda(string nombre_moneda )
        {
            sn.BorrarMoneda(nombre_moneda);
        }

    }
}
