using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace PdfGenerator.Controllers
{    
    public class GeneratePdfController : Controller 
    {    
        [HttpGet]
        [Route("DownloadPdf")]
        public IActionResult DownloadPdf()
        {
            var pdfGenerator = new BlazorPdf.GeneratePdf($"https://{Request.Host.Value}/");
            var pdf = pdfGenerator.getPdf();
            var pdfStream = new System.IO.MemoryStream(pdf);            
            return new FileStreamResult(pdfStream, "application/pdf");
        }
    }
}
