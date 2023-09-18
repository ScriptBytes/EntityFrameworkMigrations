using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFMigrationsDemo.Entities;

[Table("address", Schema = "add")]
public class Address
{
    [Column("id")]
    public int Id { get; set; }
    [Column("person_id")]
    public int PersonId { get; set; }
    [Column("address")]
    [MaxLength(100)]
    public string Address1 { get; set; }
    [Column("address2")]
    [MaxLength(100)]
    public string? Address2 { get; set; }
    [Column("city")]
    [MaxLength(100)]
    public string City { get; set; }
    [Column("state")]
    [MaxLength(2)]
    public string State { get; set; }
    [Column("zip")]
    [MaxLength(5)]
    public string Zip { get; set; }
    public Person Person { get; set; }
}