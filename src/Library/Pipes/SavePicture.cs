using System;
using System.Drawing;
using CompAndDel;

namespace CompAndDel.Filters
{
    public class SavePicture : IFilter
    {
        public IPicture Filter(IPicture image)
        {
            return image;
        }
    }
}