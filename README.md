# BlazorPdf

<pre style="font-family:Consolas;font-size:13px;color:gainsboro;background:#1e1e1e;">[<span style="color:#4ec9b0;">Route</span>(<span style="color:#d69d85;">&quot;[controller]&quot;</span>)]
[<span style="color:#4ec9b0;">ApiController</span>]
<span style="color:#569cd6;">public</span>&nbsp;<span style="color:#569cd6;">class</span>&nbsp;<span style="color:#4ec9b0;">GeneratePdfController</span>&nbsp;:&nbsp;<span style="color:#4ec9b0;">ControllerBase</span>&nbsp;
{&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;[<span style="color:#4ec9b0;">HttpGet</span>]
&nbsp;&nbsp;&nbsp;&nbsp;[<span style="color:#4ec9b0;">Route</span>(<span style="color:#d69d85;">&quot;DownloadPdf&quot;</span>)]
&nbsp;&nbsp;&nbsp;&nbsp;<span style="color:#569cd6;">public</span>&nbsp;<span style="color:#b8d7a3;">IActionResult</span>&nbsp;<span style="color:#dcdcaa;">DownloadPdf</span>()
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style="color:#569cd6;">var</span>&nbsp;<span style="color:#9cdcfe;">pdfGenerator</span>&nbsp;<span style="color:#b4b4b4;">=</span>&nbsp;<span style="color:#569cd6;">new</span>&nbsp;BlazorPdf<span style="color:#b4b4b4;">.</span><span style="color:#4ec9b0;">GeneratePdf</span>(<span style="color:#d69d85;">$&quot;https://www.google.fr/&quot;</span>);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style="color:#569cd6;">var</span>&nbsp;<span style="color:#9cdcfe;">pdf</span>&nbsp;<span style="color:#b4b4b4;">=</span>&nbsp;<span style="color:#9cdcfe;">pdfGenerator</span><span style="color:#b4b4b4;">.</span><span style="color:#dcdcaa;">getPdf</span>();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style="color:#569cd6;">var</span>&nbsp;<span style="color:#9cdcfe;">pdfStream</span>&nbsp;<span style="color:#b4b4b4;">=</span>&nbsp;<span style="color:#569cd6;">new</span>&nbsp;System<span style="color:#b4b4b4;">.</span>IO<span style="color:#b4b4b4;">.</span><span style="color:#4ec9b0;">MemoryStream</span>(<span style="color:#9cdcfe;">pdf</span>);&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style="color:#d8a0df;">return</span>&nbsp;<span style="color:#569cd6;">new</span>&nbsp;<span style="color:#4ec9b0;">FileStreamResult</span>(<span style="color:#9cdcfe;">pdfStream</span>,&nbsp;<span style="color:#d69d85;">&quot;application/pdf&quot;</span>);
&nbsp;&nbsp;&nbsp;&nbsp;}
}</pre>
