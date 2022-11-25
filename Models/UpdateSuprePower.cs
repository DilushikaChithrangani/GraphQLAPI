using System.ComponentModel.DataAnnotations;


namespace GraphQLAPI.Models;

public class UpdateSuprePower
{
    [Key]

    public Guid Id { get; set; }
    public string? SuperPower { get; set; }

    public string? Description { get; set; }

    public Guid SuperheroId { get; set; }

    public Superhero? Superhero { get; set; }
}
