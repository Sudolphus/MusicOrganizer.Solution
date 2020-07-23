using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using MusicOrganizer.Models;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class ArtistTest : IDisposable
  {
    public void Dispose()
    {
      Artist.ClearAll();
    }

    [TestMethod]
    public void ArtistConstructor_CanCreateAlbumObject_MatchType()
    {
      Artist newArtist = new Artist("Paul Simon");
      Assert.AreEqual(typeof(Artist), newArtist.GetType());
      Assert.AreEqual("Paul Simon", newArtist.ArtistName);
    }

    [TestMethod]
    public void ArtistList_ArtistsAreAddedToList_ListAdd()
    {
      Artist newArtist = new Artist("Radiohead");
      List<Artist> expectedList = new List<Artist> { newArtist };
      CollectionAssert.AreEqual(expectedList, Artist.GetAll());
    }

    [TestMethod]
    public void GetAlbums_GetListOfAlbumsByArtist_List()
    {
      Artist newArtist = new Artist("Radiohead");
      Album newAlbum1 = new Album("OK Computer", "Radiohead");
      Album newAlbum2 = new Album("Kid A", "Radiohead");
      newArtist.AddAlbum(newAlbum1);
      newArtist.AddAlbum(newAlbum2);
      List<Album> _expectedList = new List<Album> { newAlbum1, newAlbum2 };
      CollectionAssert.AreEqual(_expectedList, newArtist.GetAlbums());
    }

    [TestMethod]
    public void DeleteAlbum_RemoveAnAlbumFromAnArtist_DoesNotContain()
    {
      Artist newArtist = new Artist("Paul Simon");
      Album newAlbum = new Album("Graceland", "Paul Simon");
      newArtist.AddAlbum(newAlbum);
      newArtist.DeleteAlbum(newAlbum);
      CollectionAssert.DoesNotContain(newArtist.GetAlbums(), newAlbum);
    }

    [TestMethod]
    public void DeleteArtist_RemoveAnEntireArtist_DoesNotContain()
    {
      Artist newArtist = new Artist("Paul Simon");
      Artist.DeleteArtist(newArtist);
      CollectionAssert.DoesNotContain(Artist.GetAll(), newArtist);
    }
  }
}