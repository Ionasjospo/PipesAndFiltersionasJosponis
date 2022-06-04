using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompAndDel.Filters;
using CognitiveCoreUCU;

namespace CompAndDel.Pipes
{
    public class ConditionalPipe : IPipe
    {
        protected IFilter trueFiltro;
        protected IFilter falseFiltro;
        protected IPipe nextPipe;
        public bool whichFilter = false;

       private ConditionalFilter conditionalFilter1;
    
        
        /// <summary>
        /// La cañería recibe una imagen, le aplica un filtro si tiene una cara o le aplica otro si no contiene cara.
        /// </summary>
        /// <param name="trueFiltro">Filtro que se aplica si la imagen contiene una cara</param>
        /// <param name="falseFiltro">Filtro que se aplica si la imagen no contiene una cara</param>
        /// <param name="nextPipe">Siguiente cañería</param>
        public ConditionalPipe(ConditionalFilter conditionalFilter,IFilter trueFiltro, IFilter falseFiltro, IPipe nextPipe)
        {
            this.whichFilter = conditionalFilter.HasFace;
       
            this.nextPipe = nextPipe;
            this.trueFiltro = trueFiltro;
            this.falseFiltro = falseFiltro;
        }
        
        /// <summary>
        /// Devuelve el proximo IPipe
        /// </summary>
        public IPipe Next
        {
            get { return this.nextPipe; }
        }
        
        /// <summary>
        /// Devuelve el IFilter que aplica este pipe
        /// </summary>
        public IFilter Filter
        {
            get
            {
                if (this.whichFilter == true)
                {
                    return this.trueFiltro;
                }
                return this.falseFiltro;
            }
        }
        /// <summary>
        /// Recibe una imagen, le aplica un filtro y la envía al siguiente Pipe
        /// </summary>
        /// <param name="picture">Imagen a la cual se debe aplicar el filtro</param>
        public IPicture Send(IPicture picture)
        {
            if (this.whichFilter == true)
            {
                picture = this.trueFiltro.Filter(picture);
            }
            picture = this.falseFiltro.Filter(picture);            
            return this.nextPipe.Send(picture);
        }
    }
}
