﻿using music_downloader.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace music_downloader
{
    public class ArtistViewModel : MusicViewModel, IHasArtist
    {
        Artist artist;
        public ArtistViewModel(Artist a):base(a)
        {
            artist = a;
        }
        public string ArtistName { get { return artist.Name; } }

        public string ArtistId
        {
            get { return artist.Id; }
        }
    }
}