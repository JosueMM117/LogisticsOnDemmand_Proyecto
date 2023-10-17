using Firebase.Auth;
using Firebase.Database;
using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsOnDemmand_Proyecto.Capa_Datos
{
    public class CD_ConexionFireBase
    {
        public static FirebaseClient FireBase_Connect = new FirebaseClient("link de su base de datos");
        public static string WebApiKey = "Token de la cuenta";
        //public IFirebaseConfig config = new FirebaseConfig
        //{
            
        //};
        //public DataTable tabladetalles = new DataTable();
    }
}
