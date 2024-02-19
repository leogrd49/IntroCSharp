using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCSharp.App._3.Model;

/// <summary>
/// Marque
/// </summary>
internal class Brand
{
    /// <summary>
    /// Nom Biere
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Liste des biere de la marque
    /// </summary>
    public List<Beer> Beers { get; set; }
}
