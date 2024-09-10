using System.ComponentModel.DataAnnotations;

namespace csharpwebapi.Models;
public class Tutorial
{
    public int? Id { get; set; }  // Nullable int for optional id
    public required string Title { get; set; }
    public required string Description { get; set; }
    public bool? Published { get; set; }  // Nullable bool for optional published status
}
