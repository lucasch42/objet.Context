using System;
using System.Collections.Generic;

namespace objet.Context.Models;

public partial class ObjetTrouve
{
    public int Objetid { get; set; }

    public string? Nom { get; set; }

    public DateTime? Datedecouverte { get; set; }

    public string? Numeroserie { get; set; }

    public string? Couleur { get; set; }

    public string? Description { get; set; }

    public int Salarieid { get; set; }

    public int Categorieid { get; set; }

    public int Lieuxid { get; set; }

    public int Usagerid { get; set; }

    public virtual Categorie Categorie { get; set; } = null!;

    public virtual Lieu Lieux { get; set; } = null!;

    public virtual Salarie Salarie { get; set; } = null!;

    public virtual Usager Usager { get; set; } = null!;
}
