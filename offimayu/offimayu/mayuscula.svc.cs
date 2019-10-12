using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace offimayu
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "mayuscula" en el código, en svc y en el archivo de configuración a la vez.
    public class mayuscula : Imayuscula
    {
        public string minu(string value)
        {
            return value.ToLower();

        }
        public string mayu(string value)
        {
            return value.ToUpper();

        }
        
        
    }
}
