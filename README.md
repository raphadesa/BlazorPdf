# BlazorPdf

Simply use this nuget Package : 

Install-Package BlazorInputMask

And then :

[HttpGet]
        [Route("DownloadPdf")]
        public IActionResult DownloadPdf()
        {
            var pdfGenerator = new BlazorPdf.GeneratePdf("https://www.google.fr");
            var pdf = pdfGenerator.getPdf();
            var pdfStream = new System.IO.MemoryStream();
            pdfStream.Write(pdf, 0, pdf.Length);
            pdfStream.Position = 0;
            return new FileStreamResult(pdfStream, "application/pdf");
        }
