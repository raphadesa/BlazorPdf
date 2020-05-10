using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace PdfGenerator.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GeneratePdfController : ControllerBase 
    {    
        [HttpGet]
        [Route("DownloadPdf")]
        public IActionResult DownloadPdf()
        {
            var pdfGenerator = new BlazorPdf.GeneratePdf($"https://{Request.Host.Value}/");
            var pdf = pdfGenerator.getPdf();
            var pdfStream = new System.IO.MemoryStream();
            pdfStream.Write(pdf, 0, pdf.Length);
            pdfStream.Position = 0;
            return new FileStreamResult(pdfStream, "application/pdf");
        }
    }
}
