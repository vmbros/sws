using System;
using System.Drawing;
using System.IO;
using System.Net;
//using System.Windows.Forms;
namespace cCamara
{
    public class cCamara
    {
        public string rutaImages;
        public string rutaCamara;
        public string user;
        public string pass;

        static void Main()
        {

        }
        public string takeSnapshot(string TicketNum, string Linea, string FolioPref)
        {
            string result, rutaI, filename;
            string sourceURL = rutaCamara;
            byte[] buffer = new byte[1000000];
            int read, total = 0;
            // create HTTP request
           

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(sourceURL);
            req.Credentials = new NetworkCredential(user, pass);

            //MessageBox.Show("try to stream");
            try
            {
                // get response
                WebResponse resp = req.GetResponse();
                //MessageBox.Show("webrespose");
                // get response stream
                Stream stream = resp.GetResponseStream();
                //MessageBox.Show("getstream");
                // read data from stream
                while ((read = stream.Read(buffer, total, 1000)) != 0)
                {
                    total += read;
                }
                //MessageBox.Show("while");
            }
            catch (Exception e)
            {
                //MessageBox.Show("webresponse:" + e.Message);
                result = e.Message;
                return result;
            }

            // get bitmap
            filename = FolioPref + "-" + TicketNum + "L" + Linea + String.Format("{0:yyyyMMddHHmmss}", DateTime.Now) +".jpg";
            rutaI = rutaImages + filename ;
            //MessageBox.Show("try to get bitmap. RUTA:" + rutaI);
            try
            {
                //MessageBox.Show("in try ");
                Bitmap bmp = (Bitmap)Bitmap.FromStream(new MemoryStream(buffer, 0, total));
                bmp.Save(rutaI, System.Drawing.Imaging.ImageFormat.Jpeg);
                
                result = filename;
                bmp.Dispose();
            }
            catch (Exception e)
            {
                //MessageBox.Show("catch try to bitmap: "+ e.Message);
                result = e.Message;
            }

            return result;
            
        }

        public string delSnapshot(string foto)
        {
            string result, rutaI;
            rutaI = rutaImages + foto;
            if (File.Exists(rutaI))
            {
                File.Delete(rutaI);
                result = "Se ha eliminado el archivo " + foto;
            }
            else
            {
                result = foto + " No es un archivo válido.";
            }
            return result;
        }
    
    }
}
