using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models;

public class Planet
{
  public int ID { get; set; }

  [Required]
  public string Name { get; set; }

  [Required]
  public string Description { get; set; }

  public Planet(String Name, String Description)
  {
    this.Name = Name;
    this.Description = Description;
  }
}