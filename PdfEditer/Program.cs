using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfEditer;

var filePath = @"D:\Work\projects\PdfEditer\PdfEditer";
var fileName = "Document1.pdf";
Pdf.CreateNewPdfDocument(fileName, filePath, 100);