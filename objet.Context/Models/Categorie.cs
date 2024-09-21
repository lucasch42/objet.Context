using System;
using System.Collections.Generic;

namespace objet.Context.Models;

public partial class Categorie
{
    public int Categorieid { get; set; }

    public string? Nom { get; set; }

    public virtual ICollection<ObjetTrouve> ObjetTrouves { get; set; } = new List<ObjetTrouve>();
}
