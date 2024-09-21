using System;
using System.Collections.Generic;

namespace objet.Context.Models;

public partial class Entreprise
{
    public int Entrepriseid { get; set; }

    public string? Nom { get; set; }

    public string? Pays { get; set; }

    public string? Adresse { get; set; }

    public string? Ville { get; set; }

    public string? Codepostal { get; set; }

    public string? Numerosiret { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Lieu> Lieus { get; set; } = new List<Lieu>();

    public virtual ICollection<Salarie> Salaries { get; set; } = new List<Salarie>();
}
