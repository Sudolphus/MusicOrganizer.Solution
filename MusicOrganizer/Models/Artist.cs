using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Artist
  {
    public string ArtistName { get; set; }
    private List<Album> _albumList = new List<Album>();
    private static List<Artist> _artistList = new List<Artist>();
    public int Id { get ;}
    private static int _currentId = 0;
    private static Dictionary<int, Artist> _idDictionary = new Dictionary<int, Artist>();

    public Artist(string artistName)
    {
      ArtistName = artistName;
      _artistList.Add(this);
      Id = _currentId;
      _currentId ++;
      _idDictionary.Add(Id, this);
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

    public static void ClearCurrentId()
    {
      _currentId = 0;
    }

    public static void ClearDictionary()
    {
      _idDictionary.Clear();
    }

    public void DeleteAlbum(Album albumName)
    {
      _albumList.Remove(albumName);
    }

    public static void DeleteArtist(Artist artistName)
    {
      _artistList.Remove(artistName);
    }

    public static Artist FindArtist(int id)
    {
      return _idDictionary[id];
    }

    public static Artist FindArtistByName(string artistName)
    {
      for (int i = 0; i < _artistList.Count; i++)
      {
        if (artistName == _artistList[i].ArtistName) {
          return _artistList[i];
        }
      }
      return null;
    }
  }
}