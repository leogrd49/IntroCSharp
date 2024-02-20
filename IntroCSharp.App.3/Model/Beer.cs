using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCSharp.App._3.Model;

/// <summary>
/// Caractéristique Biere
/// </summary>
internal class Beer : Beverage
{


    /// <summary>
    /// Init une biere
    /// </summary>
    /// <param name="name">Nom biere</param>
    /// <param name="price">Prix Biere</param>
    /// <param name="brand">Marque Biere</param>
    /// <param name="percentAlcohol">%Alcool Biere</param>
    public Beer(string name, double price, Brand brand, double percentAlcohol) 
        : base(name, price, brand) 
        => PercentAlcohol = percentAlcohol;

    /// <summary>
    /// % Alcool
    /// </summary>
    public double PercentAlcohol { get; set; }


    /// <summary>
    /// Donne les informations sur la biere
    /// </summary>
    /// <returns></returns>
    public override string ToString() => "[BIERE] > " + base.ToString();
    
}