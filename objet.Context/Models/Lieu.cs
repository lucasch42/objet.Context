using System;
using System.Collections.Generic;

namespace objet.Context.Models;

public partial class Lieu
{
    public int Lieuxid { get; set; }

    public string? Nom { get; set; }

    public string? Description { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public int Entrepriseid { get; set; }

    public virtual Entreprise Entreprise { get; set; } = null!;

    public virtual ICollection<ObjetTrouve> ObjetTrouves { get; set; } = new List<ObjetTrouve>();
}
