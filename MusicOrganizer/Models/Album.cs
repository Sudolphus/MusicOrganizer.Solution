using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Album
  {
    public string AlbumName { get; set; }
    public string ArtistName { get; set; }
    private static List<Album> _albumList = new List<Album>();

    public Album (string albumName, string artistName)
    {
      AlbumName = albumName;
      ArtistName = artistName;
      _albumList.Add(this);
    }

    public static List<Album> GetAll()
    {
      return _albumList;
    }

    public static void ClearAll()
    {
      _albumList.Clear();
    }

  }
}