using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCSharp.App._3.Model
{
    internal class Beverage
    {
        /// <summary>
        /// Nom 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Price
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Marque Associé
        /// </summary>
        public Brand Brand { get; set; }
    }
}
