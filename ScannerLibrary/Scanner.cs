using QRCodeEncoderDecoderLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Xml.Serialization;
using System.Linq;
using TwainDotNet;
using TwainDotNet.TwainNative;
using DevExpress.Pdf;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;

namespace Kibernetes.Services.ScannerLibrary
{
    public class Scanner
    {  
            private QRDecoder QRCodeDecoder;
            private Bitmap QRCodeInputImage;
            public List<DocumentiScannerizzati> lstDocumenti;
            private String TextQr = string.Empty;
            public DocumentiScannerizzati noQR = null;
            private static AreaSettings AreaSettings = new AreaSettings(Units.Centimeters, 0.1f, 5.7f, 0.1F + 2.6f, 5.7f + 2.6f);
            public Twain twain;
            public bool IsPrintable=false;
            public Boolean QrTrovato = false;
            public  Boolean QrTrovatoPrecedente = false;

        public bool splitPdf = false;

        public Scanner(System.Windows.Forms.Form window)
            {
             
                List<Bitmap> lstImage = new List<Bitmap>();
                lstDocumenti = DeserializzaListaFile();
                if (lstDocumenti == null)
                {
                lstDocumenti = new List<DocumentiScannerizzati>();
                }
                DocumentiScannerizzati dc = new DocumentiScannerizzati();        
                twain = new Twain(new WinFormsWindowMessageHook(window));
                twain.TransferImage += delegate (Object sender, TransferImageEventArgs args)
                {
                    if (args.Image != null)
                    {
                        IsPrintable = true;
                        QRCodeDecoder = new QRDecoder();
                        QRCodeInputImage = new Bitmap(args.Image);
                        var text = String.Empty;
                        byte[][] DataByteArray = QRCodeDecoder.ImageDecoder(args.Image);
                        text = QRDecoder.QRCodeResult(DataByteArray);

                      
                        TextQr += text;

                        if (String.IsNullOrEmpty(text) && dc.lstImage.Count == 0) 
                        {

                            QrTrovato = false;
                         }else if(String.IsNullOrEmpty(text)== false) {

                            QrTrovato = true;

                         
                        } 

                        if (QrTrovato)
                        {

                          //  if (String.IsNullOrEmpty(text) || text.StartsWith("kiberne") == false)
                     
                                    if (String.IsNullOrEmpty(text))
                                    {
                                        ElementoScannerizzato es = new ElementoScannerizzato();
                                        es.image =  imageToByteArray( args.Image);
                                        dc.lstImage.Add(es);
                                        
                                    }
                                    else
                                    {

                                        dc = new DocumentiScannerizzati();
                                        dc.QrCodeString = text;
                                        var parametri = text.Split("/".ToCharArray());
                                        int anno;
                                        int numero;
                                        int.TryParse(parametri[1].ToString(), out anno);
                                        int.TryParse(parametri[2].ToString(), out numero);
                                        dc.AnnoProtocollo  = anno;
                                        dc.NumeroProtocollo  = numero ;
                                        dc.DataScansione = DateTime.Now;
                                        
                                        dc.Descrizione = string.Format("Protocollo {0}/{1}", anno, numero);
                                        ElementoScannerizzato es = new ElementoScannerizzato();
                                        es.image =imageToByteArray( args.Image);
                                        dc.lstImage.Add(es);
                                        lstDocumenti.Add(dc); 
                                    }
                        }

                        else if (QrTrovatoPrecedente == false)
                        {
                            if (noQR == null )
                            {
                                noQR = new DocumentiScannerizzati();
                                noQR.Descrizione = "Protocollo da associare";
                                noQR.DataScansione = DateTime.Now;
                              
                            }
                            ElementoScannerizzato es = new ElementoScannerizzato();
                            es.image = imageToByteArray(args.Image);
                            noQR.lstImage.Add(es); 
                        }
                        else
                        {  
                            dc = new DocumentiScannerizzati();
                            dc.QrCodeString = "Protocollo da associare";
                            ElementoScannerizzato es = new ElementoScannerizzato();
                            es.image = imageToByteArray(args.Image);
                            dc.lstImage.Add(es);
                        } 
                        QrTrovatoPrecedente = QrTrovato;

                    }
                };
               
            }


        public void SerializzaListaFile() { 

            try
            {
                List<DocumentiScannerizzati> lstDocumentiSer = new List<DocumentiScannerizzati>();

               if (lstDocumenti != null && lstDocumenti.Count > 0)
                { 
                    foreach (DocumentiScannerizzati r in lstDocumenti)
                    {

                        if (r.lstImage != null && r.lstImage.Count > 0)
                        {
                            try
                            {
                            
                                r.ricalcolaDescrizione();
                                lstDocumentiSer.Add(r);
                               
                            }
                            catch (Exception e)
                            {
                                throw new Exception(e.Message);
                            }

                        }

                    }
                }

                if (lstDocumentiSer != null && lstDocumentiSer.Count >= 0)
                {

                    XmlSerializer serConfigurazione = new XmlSerializer(typeof(List<DocumentiScannerizzati>));
                    byte[] Buffer = null;
                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                    {
                        serConfigurazione.Serialize(ms, lstDocumentiSer);
                        Buffer = ms.ToArray();
                    }
                    System.IO.File.WriteAllBytes(System.IO.Path.Combine(System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "Tracciato"), "FileScannerrizzati.xml"), Buffer);
                }
               
            }
            catch (Exception e)
            {
                System.IO.File.WriteAllText(System.IO.Path.Combine(System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "Tracciato"), "error.txt"), e.InnerException.Message );
            }
            
        }


        public List<DocumentiScannerizzati> DeserializzaListaFile()
        {

            try {           
                List<DocumentiScannerizzati> lstDocumentiSer= null ;
                List<DocumentiScannerizzati> lstDocumenti= null;
                byte[] buffer = null;     
                XmlSerializer serConfigurazione = new XmlSerializer(typeof(List<DocumentiScannerizzati>));
           
                    buffer = System.IO.File.ReadAllBytes(System.IO.Path.Combine(System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "Tracciato"), "FileScannerrizzati.xml"));
                    if (buffer != null) {
                        using (System.IO.MemoryStream ms = new System.IO.MemoryStream(buffer))
                        {
                            lstDocumentiSer = (List<DocumentiScannerizzati>)serConfigurazione.Deserialize(ms);
                        }

                    } 

                    if (lstDocumentiSer != null && lstDocumentiSer.Count > 0)
            {


                foreach (DocumentiScannerizzati r in lstDocumentiSer)
                {

                    if (r.lstImage  != null  && r.lstImage .Count >0)
                    {
                        try
                        {
                            //var lstImage = GetAllPages(r.buffer);
                            //if (lstImage != null && lstImage .Count>0)
                            //{

                                if (lstDocumenti == null) {
                                    lstDocumenti = new List<DocumentiScannerizzati>();
                                }
                             //   r.lstImage = lstImage;

                                lstDocumenti.Add(r);
                            //}
                        }
                        catch (Exception e)
                        {
                            throw new Exception(e.Message);
                        }

                    }

                }
            }


                    return lstDocumenti;

                }
                catch (Exception ex)
                {
                //System.IO.File.WriteAllText(System.IO.Path.Combine(System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "Tracciato"), "errorDeserializzazione.txt"), ex.InnerException.Message); 
            }
            return null;
        }


        private ImageCodecInfo GetImageEncoder(string type)
            {
                foreach (ImageCodecInfo i in ImageCodecInfo.GetImageEncoders())
                {
                    if (i.MimeType == type)
                    {
                        return i;
                    }
                }
                return null;
            }



        private byte[] GetPDFByte(List<ElementoScannerizzato> imgs) {

            byte[] buffer = null;
            if (imgs != null && imgs.Count > 0)
            {
                    using (RichEditDocumentServer server = new RichEditDocumentServer())
                    {
                        DocumentImage docImage = server.Document.Images.Append(DocumentImageSource.FromImage(byteArrayToImage(imgs[0].image)));
                        server.Document.Sections[0].Page.Width = docImage.Size.Width + server.Document.Sections[0].Margins.Right + server.Document.Sections[0].Margins.Left;
                        server.Document.Sections[0].Page.Height = docImage.Size.Height + server.Document.Sections[0].Margins.Top + server.Document.Sections[0].Margins.Bottom;
                        for (int i = 1; i < imgs.Count; i++)
                        {
                            Image tiff1 = byteArrayToImage(imgs[i].image);
                            DocumentImage docImagei = server.Document.Images.Append(DocumentImageSource.FromImage(tiff1));
                            server.Document.Sections[0].Page.Width = docImagei.Size.Width + server.Document.Sections[0].Margins.Right + server.Document.Sections[0].Margins.Left;
                            server.Document.Sections[0].Page.Height = docImagei.Size.Height + server.Document.Sections[0].Margins.Top + server.Document.Sections[0].Margins.Bottom;
                        }
                        using (MemoryStream ms = new MemoryStream())
                        {
                        DevExpress.XtraPrinting.PdfExportOptions pdfExportOptions = new DevExpress.XtraPrinting.PdfExportOptions();
                        pdfExportOptions.ConvertImagesToJpeg = true;
                      
                        pdfExportOptions.ImageQuality = DevExpress.XtraPrinting.PdfJpegImageQuality.Medium ;
                            server.ExportToPdf(ms, pdfExportOptions);
                            buffer = ms.GetBuffer();
                        }
                    }
            }
            
                return buffer;
        }

        private byte[] GetPDFByte(ElementoScannerizzato imgs)
        {

            byte[] buffer = null;
            if (imgs != null )
            {
                using (RichEditDocumentServer server = new RichEditDocumentServer())
                {
                    DocumentImage docImage = server.Document.Images.Append(DocumentImageSource.FromImage(byteArrayToImage(imgs.image)));
                    server.Document.Sections[0].Page.Width = docImage.Size.Width + server.Document.Sections[0].Margins.Right + server.Document.Sections[0].Margins.Left;
                    server.Document.Sections[0].Page.Height = docImage.Size.Height + server.Document.Sections[0].Margins.Top + server.Document.Sections[0].Margins.Bottom;               
                    using (MemoryStream ms = new MemoryStream())
                    {
                        
                        server.ExportToPdf(ms);
                        buffer = ms.GetBuffer();
                    }
                }
            }
            return buffer;
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imageIn.Save(ms, ImageFormat .Jpeg);
                return ms.ToArray();
            }
              
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            Image returnImage = null;
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                returnImage = Image.FromStream(ms);
            }
            return returnImage;
        }


        public Kibernetes.Services.ScannerLibrary.srvDocumentiProtocollo.ExportResult SaveImage1(List<ElementoScannerizzato> imgs, string fileName)
            {
    
            try
            {
                using (MemoryStream ms1 = new MemoryStream())
                {
                    Image tiff = byteArrayToImage ( imgs[0].image) ;
                    EncoderParameters encparams = new EncoderParameters(1);
                    encparams.Param[0] = new System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.SaveFlag, (long)EncoderValue.MultiFrame);
                    tiff.Save(ms1, GetImageEncoder("image/tiff"), encparams);
                    for (int i = 1; i < imgs.Count; i++)
                    {
                        Image tiff1 = byteArrayToImage(imgs[i].image);
                        EncoderParameters encparams1 = new EncoderParameters(1);
                        encparams1.Param[0] = new System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.SaveFlag, (long)EncoderValue.FrameDimensionPage);
                        tiff.SaveAdd(tiff1, encparams1);
                    }
                    encparams.Param[0] = new System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.SaveFlag, (long)EncoderValue.Flush);
                    tiff.SaveAdd(encparams);
                    byte[] bt = null;
                    bt = ms1.GetBuffer();
                    Kibernetes.Services.ScannerLibrary.srvDocumentiProtocollo.ExportResult export = new Kibernetes.Services.ScannerLibrary.srvDocumentiProtocollo.ExportResult();
                    export.Buffer = bt;
                    export.FileName = fileName;
                    //System.IO.File.WriteAllBytes(fileName + ".tiff", bt);

                    return export;
                }

             

            }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }

            }

        public void StartScanning(ScannerSetting setting)
            {
               

                try
                {
                ScanSettings settings = new ScanSettings();
                settings.AbortWhenNoPaperDetectable = setting.AbortWhenNoPaperDetectable;
                settings.Area = setting.Area;
                settings.Page = setting.Page;
                settings.Resolution = setting.Resolution;
                settings.Rotation = setting.Rotation;
                settings.ShouldTransferAllPages = setting.ShouldTransferAllPages;
                settings.ShowProgressIndicatorUI = setting.ShowProgressIndicatorUI;
                settings.ShowTwainUI = setting.ShowTwainUI;
                settings.TransferCount = setting.TransferCount;
                settings.UseAutoFeeder = setting.UseAutoFeeder;
                settings.UseAutoScanCache = setting.UseAutoScanCache;
                settings.UseDocumentFeeder = setting.UseDocumentFeeder;
                settings.UseDuplex = setting.UseDuplex;

                    twain.StartScanning(settings);
                }
                catch (TwainException ex)
                {
                    throw new Exception (ex.Message);
                 
                }
            }

        public void InviaAlProtocollo(string ParametriURL)
            {
            //string mes = "inizio";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            try
            {
               
                string PathWS = "/Services/DocumentiProtocollo.asmx";
                string Uri = new Uri(new Uri(ParametriURL), PathWS).AbsoluteUri;
                Kibernetes.Services.ScannerLibrary.srvDocumentiProtocollo.DocumentiProtocollo req = new Kibernetes.Services.ScannerLibrary.srvDocumentiProtocollo.DocumentiProtocollo();              
                req.Url = Uri;
              
                if (lstDocumenti != null && lstDocumenti.Count > 0)
                {
                 
                    var lstDaProtcollare = (from t in lstDocumenti where t.Protocollato ==false  && t.NumeroProtocollo >0 && t.AnnoProtocollo > 0 select t).ToList();

                    if (lstDaProtcollare != null && lstDaProtcollare.Count > 0)
                    {
                        
                        foreach (DocumentiScannerizzati r in lstDaProtcollare)
                        {

                            if (r.lstImage != null && r.lstImage.Count > 0)
                            {
                               
                                    var index = lstDocumenti.IndexOf(r);
                                    try
                                    {
                                        if (splitPdf == true)
                                        {
                                            int i = 1;
                                            foreach (ElementoScannerizzato t in r.lstImage) {

                                                var buffer = GetPDFByte(t);
                                                Kibernetes.Services.ScannerLibrary.srvDocumentiProtocollo.ExportResult exportResult = new srvDocumentiProtocollo.ExportResult();
                                                exportResult.Buffer = buffer;
                                                exportResult.FileName = "Allegato" + i + ".pdf";
                                                i += 1;
                                                //  var exportResult = SaveImage1(r.lstImage, "Allegato.tiff");

                                                if (exportResult != null && r.AnnoProtocollo > 0 && r.NumeroProtocollo > 0)
                                                {
                                                    Kibernetes.Services.ScannerLibrary.srvDocumentiProtocollo.DocumentiDati dcProtocollo = new Kibernetes.Services.ScannerLibrary.srvDocumentiProtocollo.DocumentiDati();
                                                    dcProtocollo.Anno = r.AnnoProtocollo;
                                                    dcProtocollo.Numero = r.NumeroProtocollo;
                                                    dcProtocollo.Documento = exportResult;
                                                    req.InviaAllegato(dcProtocollo);
                                                    //r.DataInvioProtocollo = DateTime.Now;
                                                    //r.Protocollato = true;
                                                }

                                            }
                                            r.DataInvioProtocollo = DateTime.Now;
                                            r.Protocollato = true;
                                        }
                                        else {
                                            var buffer = GetPDFByte(r.lstImage);
                                            Kibernetes.Services.ScannerLibrary.srvDocumentiProtocollo.ExportResult exportResult = new srvDocumentiProtocollo.ExportResult();
                                            exportResult.Buffer = buffer;
                                            exportResult.FileName = "Allegato.pdf";

                                        System.IO.File.WriteAllBytes("Allegato.pdf", buffer);
                                        //  var exportResult = SaveImage1(r.lstImage, "Allegato.tiff");

                                        if (exportResult != null && r.AnnoProtocollo > 0 && r.NumeroProtocollo > 0)
                                            {
                                                Kibernetes.Services.ScannerLibrary.srvDocumentiProtocollo.DocumentiDati dcProtocollo = new Kibernetes.Services.ScannerLibrary.srvDocumentiProtocollo.DocumentiDati();
                                                dcProtocollo.Anno = r.AnnoProtocollo;
                                                dcProtocollo.Numero = r.NumeroProtocollo;
                                                dcProtocollo.Documento = exportResult;
                                                var resp= req.InviaAllegato(dcProtocollo);
                                            if (resp == "OK") {
                                                r.DataInvioProtocollo = DateTime.Now;
                                                r.Protocollato = true;
                                            } else if (resp == "KO" || string.IsNullOrEmpty (resp)) {
                                                sb.AppendLine ("Errore nell'invio del file per il protocollo " +r.AnnoProtocollo+"/"+r.NumeroProtocollo );
                                            }

                                               
                                            }
                                        }
                                    }
                                    catch (Exception e)
                                    {
                                        throw new Exception(e.Message+" /"+ e.StackTrace  );
                                    }
                                var elem = (from t in lstDocumenti where t.guid == r.guid select t).FirstOrDefault ();

                                lstDocumenti[lstDocumenti.IndexOf(elem)] = r;
                                 
                            }
                        }
                    }



                }

            } 
          
            catch (Exception e)
            {
                System.IO.File.WriteAllText( "error.txt", e.Message);
            }
            finally
            {
                EliminaElementoProtocollato();
               SerializzaListaFile();
            }
            if (!string.IsNullOrEmpty(sb.ToString())) {

                System.IO.File.WriteAllText("errorInvioFile.txt", sb.ToString());

            }
            
        }



        public void AggiornaDatiDocumento(string Guid, int AnnoProtocollo, int NumeroProtocollo) {
            if (lstDocumenti != null && lstDocumenti.Count > 0)
            {
              if(String.IsNullOrEmpty(Guid) == false &&  NumeroProtocollo > 0 && AnnoProtocollo > 0 ) {
                    var obj = lstDocumenti.Where(x => x.guid == Guid).First();
                    if (obj != null) {
                        var index = lstDocumenti.IndexOf(obj);
                        obj.NumeroProtocollo = NumeroProtocollo;
                        obj.AnnoProtocollo = AnnoProtocollo;
                        obj.Descrizione = string.Format("Protocollo {0}/{1}", AnnoProtocollo, NumeroProtocollo);
                        lstDocumenti[index] = obj;
                    }
              }
                                   
            }
        } 

        private List<Image> GetAllPages(byte[] file)
        {
            using (MemoryStream ms = new MemoryStream(file))
            {
                List<Image> images = new List<Image>();
                Bitmap bitmap = (Bitmap)Image.FromStream (ms);
                int count = bitmap.GetFrameCount(FrameDimension.Page);
                for (int idx = 0; idx < count; idx++)
                {
                    bitmap.SelectActiveFrame(FrameDimension.Page, idx);
                    MemoryStream byteStream = new MemoryStream();
                    bitmap.Save(byteStream, ImageFormat.Tiff);
                    images.Add(Image.FromStream(byteStream));
                }
                return images;
            }
              
        }




        public void SvuotaTutto() {
            lstDocumenti =new List<DocumentiScannerizzati> ();

            System.IO.File.Delete (System.IO.Path.Combine(System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "Tracciato"), "FileScannerrizzati.xml"));
        }

        public bool EliminaElemento(string tag_group, string tag_item) {
            bool ok = false;

            if (lstDocumenti != null && lstDocumenti.Count > 0) {
                var obj = (from r in lstDocumenti where r.guid == tag_group select r).FirstOrDefault();
                if (obj != null && obj.lstImage != null) {
                    var itm = (from k in obj.lstImage where k.guid == tag_item select k).FirstOrDefault();
                    if (itm != null) {
                        obj.lstImage.Remove(itm);
                        SerializzaListaFile();
                        ok = true;
                    }
                    if (obj.lstImage.Count == 0) {
                        lstDocumenti.Remove(obj);
                    }
                }

            }
            return ok;
        }

        private void EliminaElementoProtocollato()
        {
            

            if (lstDocumenti != null && lstDocumenti.Count > 0)
            {

                lstDocumenti.RemoveAll(x => x.Protocollato == true);
          
            }
          
        }


        public bool SpostaElemento(string tag_group_partenza, string tag_group_destinazione, string tag_item)
        {
            bool ok = false;
            ElementoScannerizzato elm = null;
            if (tag_group_partenza.Equals(tag_group_destinazione)) {
                return false;
            }

            if (lstDocumenti != null && lstDocumenti.Count > 0)
            {
                var obj = (from r in lstDocumenti where r.guid == tag_group_partenza select r).FirstOrDefault();
                if (obj != null && obj.lstImage != null)
                {
                    var itm = (from k in obj.lstImage where k.guid == tag_item select k).FirstOrDefault();
                    if (itm != null)
                    {
                        elm = itm;
                        obj.lstImage.Remove(itm);
                       
                    }

                    if (obj.lstImage.Count == 0)
                    {
                        lstDocumenti.Remove(obj);
                    }

                }
              

                obj = (from r in lstDocumenti where r.guid == tag_group_destinazione select r).FirstOrDefault();
                if (obj != null && obj.lstImage != null) {
                    obj.lstImage.Add(elm);
                    obj.ricalcolaDescrizione();
                    ok = true;
                }

            }
            return ok;
        }




        public bool CreaNuovoGruppo(string tag_group_partenza,string tag_item) {
            bool ok = false;
            ElementoScannerizzato elm = null;
            if (lstDocumenti != null && lstDocumenti.Count > 0)
            {
                var obj = (from r in lstDocumenti where r.guid == tag_group_partenza select r).FirstOrDefault();
                if (obj != null && obj.lstImage != null)
                {
                    var itm = (from k in obj.lstImage where k.guid == tag_item select k).FirstOrDefault();
                    if (itm != null)
                    {
                        elm = itm;
                        obj.lstImage.Remove(itm);

                    }

                    if (obj.lstImage.Count == 0)
                    {
                        lstDocumenti.Remove(obj);
                    }
                }

            
            }

            if (elm != null) {
               var dc = new DocumentiScannerizzati();
              
                dc.DataScansione = DateTime.Now;
                dc.lstImage.Add(elm);
                dc.ricalcolaDescrizione();
                lstDocumenti.Add(dc);

                ok = true;
                SerializzaListaFile();
            } 

            return ok;

        }


        }

    }
