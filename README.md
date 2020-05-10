# BlazorPdf

[](https://hvpqla.am.files.1drv.com/y4mTnteP-0iRysuZmGHcDO0-9Kn6So_XFfeHJJ3AamO2ie2JiU38WMpKVoLzdH-_qeCGCwyElsv3kMgimyzE-9MnhW140O3nWnQEpwldBUkMrDdcIn5Br1JeNXV4bnpWP3itfDo7WIwCv5JYCrpjMRbYdor9E8fHnZd0WwWeF8UOzSH1z_sWOLlJWzKQBAUCCuriYNHt6Nq-oZSYaQcShOMuQ/BlazorPdf.gif?psid=1)

Based on wkhtmltopdf.exe

Get it from nuget:

install-package BlazorPdf

Note: The executable wkhtmltopdf.exe is automatically copied to your local project upon first execution, and is saved under the Rotativa folder.

<pre style="font-family:Consolas;font-size:13px;color:gainsboro;background:#1e1e1e;"><span style="color:#569cd6;">public</span>&nbsp;<span style="color:#569cd6;">class</span>&nbsp;<span style="color:#4ec9b0;">GeneratePdfController</span>&nbsp;:&nbsp;<span style="color:#4ec9b0;">Controller</span>
&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[<span style="color:#4ec9b0;">HttpGet</span>]
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[<span style="color:#4ec9b0;">Route</span>(<span style="color:#d69d85;">&quot;DownloadPdf&quot;</span>)]
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style="color:#569cd6;">public</span>&nbsp;<span style="color:#b8d7a3;">IActionResult</span>&nbsp;<span style="color:#dcdcaa;">DownloadPdf</span>()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style="color:#569cd6;">var</span>&nbsp;<span style="color:#9cdcfe;">pdfGenerator</span>&nbsp;<span style="color:#b4b4b4;">=</span>&nbsp;<span style="color:#569cd6;">new</span>&nbsp;BlazorPdf<span style="color:#b4b4b4;">.</span><span style="color:#4ec9b0;">GeneratePdf</span>(<span style="color:#d69d85;">&quot;https://www.google.fr/&quot;</span>);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style="color:#569cd6;">var</span>&nbsp;<span style="color:#9cdcfe;">pdf</span>&nbsp;<span style="color:#b4b4b4;">=</span>&nbsp;<span style="color:#9cdcfe;">pdfGenerator</span><span style="color:#b4b4b4;">.</span><span style="color:#dcdcaa;">getPdf</span>();
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style="color:#569cd6;">var</span>&nbsp;<span style="color:#9cdcfe;">pdfStream</span>&nbsp;<span style="color:#b4b4b4;">=</span>&nbsp;<span style="color:#569cd6;">new</span>&nbsp;System<span style="color:#b4b4b4;">.</span>IO<span style="color:#b4b4b4;">.</span><span style="color:#4ec9b0;">MemoryStream</span>(<span style="color:#9cdcfe;">pdf</span>);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style="color:#d8a0df;">return</span>&nbsp;<span style="color:#569cd6;">new</span>&nbsp;<span style="color:#4ec9b0;">FileStreamResult</span>(<span style="color:#9cdcfe;">pdfStream</span>,&nbsp;<span style="color:#d69d85;">&quot;application/pdf&quot;</span>);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}
&nbsp;&nbsp;&nbsp;&nbsp;}</pre>
