using System;
using System.Collections.Generic;

namespace objet.Context.Models;

public partial class Lieu
{
    public int Lieuxid { get; set; }

    public string? Nom { get; set; }

    public string? Description { get; set; }

    public int Entrepriseid { get; set; }

    public float? Latitude { get; set; }

    public float? Longitude { get; set; }

    public virtual Entreprise Entreprise { get; set; } = null!;

    public virtual ICollection<ObjetTrouve> ObjetTrouves { get; set; } = new List<ObjetTrouve>();
}
