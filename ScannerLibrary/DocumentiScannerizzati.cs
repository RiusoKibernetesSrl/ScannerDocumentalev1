using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Kibernetes.Services.ScannerLibrary
{
    public class DocumentiScannerizzati
    {




        public List<ElementoScannerizzato> lstImage = new List<ElementoScannerizzato>();
        public string guid;
        public string QrCodeString;
        public string Descrizione;
        public int AnnoProtocollo;
        public int NumeroProtocollo;
        public DateTime DataScansione;
        public bool Protocollato = false;
        public DateTime DataInvioProtocollo;
        public byte[] buffer;

        public DocumentiScannerizzati()
        {
            guid = Guid.NewGuid().ToString();
        }

        public void ricalcolaDescrizione()
        {

            if (lstImage != null && lstImage.Count > 0)
            {

                for (int i = 0; i < lstImage.Count; i++)
                {
                    int k = i + 1;
                    lstImage.ToArray()[i].descrizione = "Pagina " + k + " di " + lstImage.Count;
                }
            }






        }
    }
}
