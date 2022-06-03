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
        private bool hasFace = false;
        public bool Filter(string path)
        {
            cognitiveFace.Recognize(path);
            bool hasFace = cognitiveFace.FaceFound;
            return hasFace;
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