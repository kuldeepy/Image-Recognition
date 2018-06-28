using IronOcr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Tesseract;


namespace ReadTextFromImage
{
    class Program
    {
        delegate void Iterator();
        static void Main(string[] args)
        {
            //ArrayList iterator = new ArrayList();
            //for (int i = 0; i < 3; i++)
            //{
            //    //Iterator d = delegate { Console.WriteLine(i); };
            //    iterator.Add((Iterator)delegate { Console.WriteLine(i); });
            //}
            //foreach (var item in iterator)
            //{
            //    var i = item as Iterator;
            //    i();
            //}


            //try
            //{
            //    var Ocr = new AutoOcr();
            //    var Result = Ocr.Read(@"C:\Samples\cefazolin_vial.jpg");
            //    Console.WriteLine(Result.Text);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            try
            {
                var image = new Bitmap(@"C:\Samples\gentamicin_vial_labeled.jpg");
                var ocr = new TesseractEngine(@"./tessdata", "eng");
                var page = ocr.Process(image);
                var text = page.GetText();
                Console.WriteLine(text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

        private static void Display(int i)
        {
            Console.WriteLine(i);
        }
    }
}
