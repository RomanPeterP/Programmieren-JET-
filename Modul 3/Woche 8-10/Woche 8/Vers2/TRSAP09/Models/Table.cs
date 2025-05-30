﻿using TRSAP09.Logic;

namespace TRSAP09.Models;

public  class Table
{
    public int Id { get; } = Tools.GetNextUniqueInteger;
    public string TableNumber { get; set; } = null!;
    public byte NumberOfSeats { get; set; }
    public bool Activ { get; set; } = true;
    public Restaurant Restaurant { get; set; } = null!;
}
