using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCSharp.App._3.Model;

/// <summary>
/// Ne peut être instanciée car abstraite 
/// Doit donc etre définie par ses enfants (Ici Beer and Soda)
/// </summary>
internal abstract class Beverage
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


    /// <summary>
    /// Init une boisson
    /// </summary>
    /// <param name="name">Nom boisson</param>
    /// <param name="price">Prix</param>
    /// <param name="brand">Marque</param>
    protected Beverage(string name, double  price, Brand brand) 
    { 
        Name = name;
        Price = price;
        Brand = brand;

        brand.Beverages.Add(this);
    }

    /// <summary>
    /// Retourne 
    /// </summary>
    /// <returns></returns>
    public override string ToString() 
        => $"{Brand.Name} - {Name} - {Price}€";

}
