using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Album
  {
    public string AlbumName { get; set; }
    public string ArtistName { get; set; }
    private static List<Album> _albumList = new List<Album>();
    public int Id { get; }
    private static int _currentId = 0;
    private static Dictionary<int, Album> _idDictionary = new Dictionary<int, Album>();

    public Album (string albumName, string artistName)
    {
      AlbumName = albumName;
      ArtistName = artistName;
      _albumList.Add(this);
      Id = _currentId;
      _currentId ++;
      _idDictionary.Add(Id, this);
    }

    public static List<Album> GetAll()
    {
      return _albumList;
    }

    public static void ClearAll()
    {
      _albumList.Clear();
    }

    public static void ClearCurrentId()
    {
      _currentId = 0;
    }

    public static void ClearDictionary()
    {
      _idDictionary.Clear();
    }

    public static void DeleteAlbum(Album albumName)
    {
      _albumList.Remove(albumName);
    }

    public static Album FindAlbum(int id)
    {
      return _idDictionary[id];
    }
  }
}