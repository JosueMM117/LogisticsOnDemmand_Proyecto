﻿using Firebase.Auth;
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
        public static FirebaseClient FireBase_Connect = new FirebaseClient("https://logisticondemmand-default-rtdb.firebaseio.com/");
        public static string WebApiKey = "AIzaSyA5wKkf-pIKnit4dDcHYRIZZzrgp2SvoVQ";
        //public IFirebaseConfig config = new FirebaseConfig
        //{
            
        //};
        //public DataTable tabladetalles = new DataTable();
    }
}
