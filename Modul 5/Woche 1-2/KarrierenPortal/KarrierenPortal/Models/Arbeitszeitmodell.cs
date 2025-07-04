﻿using System;
using System.Collections.Generic;

namespace KarrierenPortal.Models;

public partial class Arbeitszeitmodell
{
    public int ArbeitszeitmodellId { get; set; }

    public string Beschreibung { get; set; } = null!;

    public virtual ICollection<JobAngebot> JobAngebots { get; set; } = new List<JobAngebot>();
}
