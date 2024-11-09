using System;
using PdfSharp.Pdf;

namespace PdfEditer;

public class Pdf
{
    /// <summary>
    /// Create new pdf at passed path and with passed file name and number of pages.
    /// </summary>
    /// <param name="pdfName"></param>
    /// <param name="filePath"></param>
    /// <param name="numberOfPages"></param>
    public static void CreateNewPdfDocument(string pdfName, string filePath, int numberOfPages)
    {
        PdfDocument document = new PdfDocument();
        for (int i = 0; i < numberOfPages; i++)
        {
            document.Pages.Add(new PdfPage());
        }
        document.Save(Path.Combine(filePath, pdfName));
    }
}
