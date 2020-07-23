using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;
using System.Collections.Generic;

namespace MusicOrganizer.Controllers
{
  public class AlbumsController : Controller
  {
    [HttpGet("/albums")]
    public ActionResult Index()
    {
      List<Album> allAlbums = Album.GetAll();
      return View(allAlbums);
    }
    [HttpGet("/albums/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/albums")]
    public ActionResult Create(string albumName, string artistName)
    {
      Album newAlbum = new Album(albumName, artistName);
      Artist foundArtist = Artist.FindArtistByName(artistName);
      if (foundArtist == null)
      {
        foundArtist = new Artist(artistName);
      }
      foundArtist.AddAlbum(newAlbum);
      return RedirectToAction("Index");
    }

    [HttpGet("/albums/{id}")]
    public ActionResult Show(int id)
    {
      Album album = Album.FindAlbum(id);
      return View(album);
    }
  }
}

