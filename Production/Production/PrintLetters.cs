//Handles Print click event

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing;
using Production;

namespace CpS_420_Inception_Project
{
    class PrintLetters
    {
        private static PrintLetters printAgent;

        public static PrintLetters PrintAgent
        {
            get
            {
                if (printAgent == null)
                {
                    printAgent = new PrintLetters();
                }
                return printAgent;
            }
        }
        private int counter = 0;
        private List<Document> documents;

        //Used: http://www.codeproject.com/Tips/453871/Simple-Receipt-Like-Printing-Using-the-Csharp-Prin as reference
        public void PrintDocuments(List<Document> d)
        {
            documents = d;
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            Font font = new Font("Calibri", 12);

            PaperSize psize = new PaperSize("Custom", 100, 200);

            pd.Document = doc;
            pd.Document.DefaultPageSettings.PaperSize = psize;

            doc.DefaultPageSettings.PaperSize.Height = 820;
            doc.DefaultPageSettings.PaperSize.Width = 520;

            doc.PrintPage += new PrintPageEventHandler(GeneratePage);
            DialogResult result = pd.ShowDialog();

            if (result == DialogResult.OK)
            {
                PrintPreviewDialog pp = new PrintPreviewDialog();
                pp.Document = doc;
                result = pp.ShowDialog();
               if (result == DialogResult.OK)
                {
                    doc.Print();
                }
            }
        }

        public void GeneratePage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Calibri", 12);
            float fontHeight = font.GetHeight();

            int startX = 50;
            int startY = 55;
            int Offset = 40;

            graphics.DrawString("DEMAND LETTER", new Font("Calibri", 18), new SolidBrush(Color.Black), startX, startY + Offset);

            while (counter < documents.Count)
            {
                Offset = Offset + 20;
                graphics.DrawString("Test " + counter , font, new SolidBrush(Color.Black), startX, startY + Offset);

                if (counter == documents.Count - 1) { e.HasMorePages = false; break; }
                else
                {
                    e.HasMorePages = true;
                    counter++; 
                    return;
                }

            }

        }
        /*public void PrintLetters()
        {
            PrintManager pm = PrintManager.DefaultPrintManager;
            List<Document> documents = pm.GetLettersToPrint();
            foreach (Document doc in documents)
            {
                PrintDocuments(doc);
            }
        }*/
    }
}
