using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace FixMens.Service
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            //Timer para el control del tiempo entre llamadas.
            var myTimer = new System.Timers.Timer();
            //Intervalo de tiempo entre llamadas.
            myTimer.Interval = 1500;
            //Evento a ejecutar cuando se cumple el tiempo.
               // myTimer.Elapsed += new System.Timers.ElapsedEventHandler(myTimer_Elapsed);
                //Habilitar el Timer.
                 myTimer.Enabled = true;
        }

        //void myTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        //    {
        //        //Detiene el Timer
        //        myTimer.Enabled = false;
        //        //llama al Servicio Web
        //        CallServicioWeb();
        //        //habilita el Timer nuevamente.
        //        myTimer.Enabled = true;
        //    }

        //void CallServicioWeb()
        //   {
        //       //Proxy
        //       SerivicioWeb.GeoIPService Proxy = new ServicioWindowsMonitor.SerivicioWeb.GeoIPService();
        //       DateTime Tini;
        //       TimeSpan Tdif;
        //       try
        //       {
        //           //Tiempo de inicio de la llamada
        //            Tini = DateTime.Now;
        //            //llamada al servicio 
        //            Proxy.GetGeoIP("200.10.12.126");
        //            //Tiempo de respuesta
        //            Tdif=Tini.Subtract(DateTime.Now);
        //            if (Tdif.Seconds< -10)
        //             {
        //                 Log("Servicio Lento: " + Tdif.Seconds.ToString()+ "[S]");
        //             }
        //        }
        //    catch (Exception X)
        //    {
             
        //            Log(X.Message);
        //        }
        //    }
    protected override void OnStop()
        {
        }
    }
}
