using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kibernetes.Services.ScannerLibrary.Utility
{
   public class Utils
    {
        public static string PathTracciatoDirectory { get; set; } = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "Tracciato");


        public static void CreateConfigurationFileScanner()
        {
            if (!System.IO.Directory.Exists(Utility.Utils.PathTracciatoDirectory))
                System.IO.Directory.CreateDirectory(Utility.Utils.PathTracciatoDirectory);

            if (!System.IO.File.Exists(System.IO.Path.Combine(Utility.Utils.PathTracciatoDirectory, "ImpostazioniScanner.xml")))
                System.IO.File.Create(System.IO.Path.Combine(Utility.Utils.PathTracciatoDirectory, "ImpostazioniScanner.xml")).Dispose();
        }

    }
}
