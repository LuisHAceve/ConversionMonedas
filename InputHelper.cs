using System;
using System.Collections.Generic;
using System.Text;

namespace ConversionMonedas
{
    internal class InputHelper
    {
        public static bool LeerEntero(string texto)
        {
            if(double.TryParse(texto, out double valor))
                   return true;
            else
                return false;
        }
    }
}
