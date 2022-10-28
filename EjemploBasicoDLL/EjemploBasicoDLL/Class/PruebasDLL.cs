using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploBasicoDLL.Class
{
    public class PruebasDLL
    {
       public String DevolverTexto(String NewText)
        {
            String ReturnString = "Hola mundo! Este es el texto insertado: " + NewText;
            return ReturnString;
        }

    }


}
