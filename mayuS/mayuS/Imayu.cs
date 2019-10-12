using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace mayuS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "Imayu" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface Imayu
    {
        [OperationContract]
        string minu(string value);
        [OperationContract]
        string mayu(string value);
       
    }
}
