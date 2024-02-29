using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Exam1_CamilleDuryea.Models;

public partial class Order
{
    [Key]
    [Column("ID")]
    public string Id { get; set; } = null!;

    [Column("wBananas")]
    public double WBananas { get; set; }

    [Column("wApples")]
    public double WApples { get; set; }

    [Column("subtotal")]
    public double Subtotal { get; set; }

    [Column("level")]
    public int Level { get; set; }
}
