using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Models;

public partial class ChristmasBall
{
    [Key]
    public int Id { get; set; }

    [Column("x", TypeName = "numeric(5, 2)")]
    public decimal X { get; set; }

    [Column("y", TypeName = "numeric(5, 2)")]
    public decimal Y { get; set; }

    [Column("radius", TypeName = "numeric(4, 2)")]
    public decimal Radius { get; set; }

    [Column("color")]
    [StringLength(10)]
    [Unicode(false)]
    public string Color { get; set; } = null!;

    [Column("effects")]
    [StringLength(2)]
    [Unicode(false)]
    public string Effects { get; set; } = null!;
}
