using System.Drawing;
using System.Collections.Generic;
using CognitiveCoreUCU;

namespace CompAndDel.Filters
{
    // <summary>
    /// Filtro que utiliza CognitiveApi. Si la imagen filtrada contiene una cara, el resultado será true, de lo contrario false.
    /// </remarks>
    public class ConditionalFilter
    {
        CognitiveFace cognitiveFace = new CognitiveFace();
        private PictureProvider pictureProvider = new PictureProvider();
        private bool hasFace = false;
        private string path;

        public ConditionalFilter (string path)
        {
            this.path = path;
            cognitiveFace.Recognize(path);
            bool hasFace = cognitiveFace.FaceFound;
        }

        public bool HasFace
        {
            get
            {
                return this.hasFace;
            }
        }
    }

}