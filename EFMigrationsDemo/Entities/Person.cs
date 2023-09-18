using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFMigrationsDemo.Entities;

[Table("person")]
public class Person
{
    [Column("person_id")]
    public int PersonId { get; set; }
    [Column("first_name")]
    [MaxLength(100)]
    public string FirstName { get; set; }
    [Column("last_name")]
    [MaxLength(100)]
    public string LastName { get; set; }
    [Column("birth_date")]
    public DateTime DateOfBirth { get; set; }
    public List<Address> Addresses { get; set; }
}