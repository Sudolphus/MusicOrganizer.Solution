using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System.Collections.Generic;
// using System;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class AlbumTest
  {
    // public void Dispose()
    // {
    //   Category.ClearAll();
    // }

    [TestMethod]
    public void AlbumConstructor_CanCreateAlbumObjects_MatchType()
    {
      Album newAlbum = new Album("Graceland", "Paul Simon");
      Assert.AreEqual(typeof(Album), newAlbum.GetType());
      Assert.AreEqual("Graceland", newAlbum.AlbumName);
      Assert.AreEqual("Paul Simon", newAlbum.ArtistName);
    }
  }
}