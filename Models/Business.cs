using System.ComponentModel.DataAnnotations;

namespace BizzWhizzApi.Models
{
  public class Business
  {
    public int BusinessId { get; set; }
    public string BusinessType { get; set; }
    public string BusinessName { get; set; }
    public string BusinessLocation { get; set; }
    [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
    public int Rating { get; set; }
  }
}