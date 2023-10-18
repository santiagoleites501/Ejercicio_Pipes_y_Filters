using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture("luke.jpg");
            Pipe.Serial();
            provider.SavePicture(picture, "lukeSk.jpg");// aplicar secuencia de filtros con pipeserial y el ultimo es pipenul
        }
    }
}
