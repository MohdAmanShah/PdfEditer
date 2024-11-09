using PdfSharp.Pdf.IO;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfEditer
{
    internal class InsertPagesToPdf
    {
        /// <summary>
        /// Insert a blank page after every page in the pdf file passed and return the new pdf document.
        /// </summary>
        /// <param name="sourceDocument">Pass the source pdf which needs to be edited</param>
        /// <returns></returns>
        public static PdfDocument InsertAlternateBlankPages(PdfDocument sourceDocument)
        {
            PdfDocument newDoc = new PdfDocument();
            foreach (var page in sourceDocument.Pages)
            {
                newDoc.AddPage(page);
                var newPage = new PdfPage();
                newPage.Height = page.Height;
                newPage.Width = page.Width;
                newDoc.AddPage(newPage);
            }
            return newDoc;
        }
    }
}
