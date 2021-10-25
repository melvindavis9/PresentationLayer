using System;

namespace Models
{
    public class Podcast
    {
        private int avsnitt;
        private string namn;
        private string uppdatering;
        private string kategori;

        public Podcast(int avsnitt, string namn, string uppdatering, string kategori)
        {
            this.avsnitt = avsnitt;
            this.namn = namn;
            this.uppdatering = uppdatering;
            this.kategori = kategori;
        }

        public int Avsnitt
        {
            get
            {
                return avsnitt;
            }
        }
        public string Namn
        {
            get
            {
                return namn;
            }
        }
        public string Uppdatering
        {
            get
            {
                return uppdatering;
            }
        }
        public string Kategori
        {
            get
            {
                return kategori;
            }
        }
    }
}