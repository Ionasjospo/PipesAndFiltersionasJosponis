using System.Drawing;
using System.Collections.Generic;

namespace CompAndDel.Filters
{
    // <summary>
    /// Un filtro que guarda una imagen.
    /// </remarks>
    public class ConsistenceFilter : IFilter
    {
       
        private int num = 0;
        
        int i = 0;
        
        public IPicture Filter(IPicture image)
        {
            PictureProvider.SavePicture(image, @$"imageTransformed{num}.jpg" );
            num++;
            return image;
        }
    }
}

