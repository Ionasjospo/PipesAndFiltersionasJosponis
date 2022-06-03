using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;
using TwitterUCU;
using CognitiveCoreUCU;


namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------------- PARTE 1 -------------------
            
            // PictureProvider provider = new PictureProvider();
            // IPicture picture = provider.GetPicture(@"beer.jpg");
           
            // PipeNull pipeNull = new PipeNull();

            // FilterNegative filterNegative = new FilterNegative();

            // PipeSerial pipeSerial2 = new PipeSerial(filterNegative, pipeNull);
            // FilterGreyscale filterGreyscale = new FilterGreyscale();

            // PipeSerial pipeSerial1 = new PipeSerial(filterGreyscale, pipeSerial2);
            // IPicture p = pipeSerial1.Send(picture);          

            // ---------------- PARTE 2 -------------------
            
            // PictureProvider provider = new PictureProvider();
            // IPicture picture = provider.GetPicture(@"luke.jpg");
           
            // PipeNull pipeNull = new PipeNull();
            


            // FilterNegative filterNegative = new FilterNegative();
            // ConsistenceFilter consistenceFilter = new ConsistenceFilter();
            // FilterGreyscale filterGreyscale = new FilterGreyscale();

            // PipeSerial pipeSerial5 = new PipeSerial(filterNegative, pipeNull);
            // PipeSerial pipeSerial2 = new PipeSerial(consistenceFilter, pipeSerial5); //guarda imagen con tercer filtro
            // PipeSerial pipeSerial4 = new PipeSerial(consistenceFilter, pipeNull); //guarda imagen con segundo filtro.
            // PipeSerial pipeSerial3 = new PipeSerial(filterNegative, pipeSerial4);

            // PipeFork pipeFork = new PipeFork(filterGreyscale, pipeSerial2 /*con filtro*/, pipeSerial3); //
            
            // PipeSerial pipeSerial1 = new PipeSerial(consistenceFilter, pipeFork); //guarda la original

            // IPicture p = pipeSerial1.Send(picture);      
            
            // PictureProvider.SavePicture(p, @"FinalImage.jpg"); //imagen con todas las transformaciones.


            // ---------------- PARTE 3 -------------------

            //var twitter = new TwitterImage();
            //Console.WriteLine(twitter.PublishToTwitter("New filtered image",@"FinalImage.jpg"));

            // ---------------- PARTE 4 -------------------
        
            ConditionalFilter conditionalFilter = new ConditionalFilter();
            
            

        }
    }
}
