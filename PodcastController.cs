using System;
using System.Collections.Generic;
using Models;

namespace BusinessLayer
{
    public class PodcastController
    {
        private List<Podcast> listOfPodcasts;

        public PodcastController()
        {
            listOfPodcasts = new List<Podcast>();
            GetPodcasts = listOfPodcasts;
            addPodcast(13, "The Matrix", "1h", "Informatik");
            addPodcast(32, "GhostAdventures", "10h", "Paranormal");
        }


        public void addPodcast(int avsnitt, string namn, string uppdatering, string kategori)
        {
            Podcast podcast = new Podcast(avsnitt, namn, uppdatering, kategori);
            listOfPodcasts.Add(podcast);

        }

        public List<Podcast> GetPodcasts { get; }
    }
}