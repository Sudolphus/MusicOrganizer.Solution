using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Artist
  {
    public string ArtistName { get; set; }
    private List<Album> _albumList = new List<Album>();
    private static List<Artist> _artistList = new List<Artist>();

    public Artist(string artistName)
    {
      ArtistName = artistName;
      _artistList.Add(this);
    }

    public void AddAlbum(Album albumName)
    {
      _albumList.Add(albumName);
    }

    public List<Album> GetAlbums()
    {
      return _albumList;
    }

    public static List<Artist> GetAll()
    {
      return _artistList;
    }

    public static void ClearAll()
    {
      _artistList.Clear();
    }

    public void DeleteAlbum(Album albumName)
    {
      _albumList.Remove(albumName);
    }
  }
}