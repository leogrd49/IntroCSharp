namespace IntroCSharp.App2.Model;

/// <summary>
/// Membre d'une classe
/// </summary>
internal class ClassMember
{
    /// <summary>
    /// Nom de famille
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// Obtient ou definit le prénom
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// Propriété calculée permettant d'obtenir le nom complet
    /// </summary>
    public string Fullname => LastName + " " + FirstName;

    /// <summary>
    /// Constructeur de la classe
    /// </summary>
    /// <param name="lastName">Nom de famille a renseigner</param>
    /// <param name="firstName">Prénom a renseigner</param>
    public ClassMember(string lastName, string firstName)
    {
        LastName = lastName;
        FirstName = firstName;
    }
}