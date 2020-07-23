using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using MusicOrganizer.Models;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class ArtistTest
  {
    [TestMethod]
    public void ArtistConstructor_CanCreateAlbumObject_MatchType()
    {
      Artist newArtist = new Artist("Paul Simon");
      Assert.AreEqual(typeof(Artist), newArtist.GetType());
      Assert.AreEqual("Paul Simon", newArtist.ArtistName);
    }
  }
}