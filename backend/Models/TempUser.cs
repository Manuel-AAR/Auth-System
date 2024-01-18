using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json.Linq;

namespace backend.Models;

public class TempUser
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(30)]
    public string Username { get; set; } = string.Empty;

    [Required]
    [StringLength(255)]
    public string Email { get; set; } = string.Empty;

    [Required]
    [StringLength(64)]
    public string Password { get; set; } = string.Empty;

    [Required]
    [StringLength(6)]
    public string Code { get; set; } = string.Empty;

}