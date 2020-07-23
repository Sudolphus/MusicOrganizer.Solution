using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Artist
  {
    public string ArtistName { get; set; }

    public Artist(string artistName)
    {
      ArtistName = artistName;
    }
  }
}