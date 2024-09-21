using System;
using System.Collections.Generic;

namespace objet.Context.Models;

public partial class Usager
{
    public int Usagerid { get; set; }

    public string? Nom { get; set; }

    public string? Prenom { get; set; }

    public string? Email { get; set; }

    public string? Motdepasse { get; set; }

    public virtual ICollection<ObjetTrouve> ObjetTrouves { get; set; } = new List<ObjetTrouve>();
}
