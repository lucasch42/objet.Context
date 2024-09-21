using System;
using System.Collections.Generic;

namespace objet.Context.Models;

public partial class Salarie
{
    public int Salarieid { get; set; }

    public string? Nom { get; set; }

    public string? Prenom { get; set; }

    public string? Email { get; set; }

    public string? Motdepasse { get; set; }

    public int Entrepriseid { get; set; }

    public virtual Entreprise Entreprise { get; set; } = null!;

    public virtual ICollection<ObjetTrouve> ObjetTrouves { get; set; } = new List<ObjetTrouve>();
}
