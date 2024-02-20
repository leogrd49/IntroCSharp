using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCSharp.App._3.Model;


/// <summary>
/// Classe d'un soda
/// </summary>
internal class Soda : Beverage
{
    /// <summary>
    /// Taux de cafféeine
    /// </summary>
    public double CaffeineRate { get; set; }

    public Soda(string name, double price, Brand brand, double cafferineRate) : base(name, price, brand)
    {
        cafferineRate = cafferineRate;
    }

    /// <summary>
    /// Info sur le soda
    /// </summary>
    /// <returns></returns>
    public override string ToString() => "[SODA] > " + base.ToString();
    
}
