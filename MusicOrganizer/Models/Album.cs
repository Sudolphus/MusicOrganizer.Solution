using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Album
  {
    public string AlbumName { get; set; }
    public string ArtistName { get; set; }

    public Album (string albumName, string artistName)
    {
      AlbumName = albumName;
      ArtistName = artistName;
    }

  }
}