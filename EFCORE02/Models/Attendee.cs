using EFCORE02.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

internal class Attendee
{
    public int AttendeeId { get; set; }

    [Required]
    [MaxLength(150)]
    public string Fullname { get; set; }

    [Required]
    [MaxLength(200)]
    public string Email { get; set; }

    [Required]
    [MaxLength(150)]
    public string Street { get; set; }

    [Required]
    [MaxLength(100)]
    public string City { get; set; }

    [Required]
    [MaxLength(100)]
    public string Country { get; set; }

    [Required]
    [MaxLength(20)]
    public string ZipCode { get; set; }
    public Badge? AttendeeBadge { get; set; }

    [NotMapped]
    public string FullAddress =>
        $"{Street}, {City}, {Country}, {ZipCode}";
    
    
}