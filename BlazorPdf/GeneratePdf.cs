using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Reflection;

namespace BlazorPdf
{
    public class GeneratePdf
    {
        private string url { get; set; }
        public GeneratePdf(string _url)
        {
            this.url = _url;
        }

        public byte[] getPdf()
        {
            var switches = $"-q {url} -";

            string rotativaLocation = Path.Combine(Directory.GetCurrentDirectory(), "rotativa","wkhtmltopdf.exe");

            using (var proc = new Process())
            {
                try
                {
                    proc.StartInfo = new ProcessStartInfo
                    {
                        FileName = rotativaLocation,
                        Arguments = switches,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        RedirectStandardInput = true,
                        CreateNoWindow = true
                    };

                    proc.Start();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                using (var ms = new MemoryStream())
                {
                    proc.StandardOutput.BaseStream.CopyTo(ms);
                    return ms.ToArray();
                }
            }
        }
    }
}


