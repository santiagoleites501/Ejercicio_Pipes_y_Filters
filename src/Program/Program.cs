using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args) //PARTE 1
        {
            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture("luke.jpg");
            FilterBlurConvolution filterBlurConvolution= new FilterBlurConvolution(picture);
            PipeNull fin = new PipeNull();
            provider.SavePicture(picture, "lukeSk.jpg");// aplicar secuencia de filtros con pipeserial y el ultimo es pipenul
            PipeSerial pipeSerial = new PipeSerial(filterBlurConvolution, fin); 
        }
        static void Main2(string[] args) //PARTE 2
        {
            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture("luke.jpg");
            provider.SavePicture(picture, "lukeSk.jpg");// aplicar secuencia de filtros con pipeserial y el ultimo es pipenul

        }
    }
}
