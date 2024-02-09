using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechCareerActivityProject.DAL.Models;

namespace TechCareerActivityProject.DAL.Data
{
    public class ConcertRepository
    {
        private static readonly List<Concert> _concerts = null;

        static ConcertRepository()
        {
            _concerts = new List<Concert>()
            {
                 new Concert
                {
                    Id=1,
                    ConcertName = "INNELLEA",
                    ConcertDescription = "Elektronik Müzik",
                    ConcertTime = "10 Şubat Cumartesi",
                    ConcertLocation = "Zorlu PSM",
                    ConcertImage = "innellea-web-mx3vo2qjss57-crop-480-480.jpg"
                },
                new Concert
                {
                    Id=2,
                    ConcertName = "SILA",
                    ConcertDescription = "Pop Müzik",
                    ConcertTime = "14 Şubat Çarşamba",
                    ConcertLocation = "Zorlu PSM",
                    ConcertImage = "channels4_profile.jpg"
                },
                new Concert
                {
                    Id=3,
                    ConcertName = "MABEL MATİZ",
                    ConcertDescription = "Pop Müzik",
                    ConcertTime = "14 Şubat Çarşamba",
                    ConcertLocation = "Volkswagen Arena",
                    ConcertImage = "mabel.jpg"
                },
                new Concert
                {
                    Id=4,
                    ConcertName = "ADRIATIQUE",
                    ConcertDescription = "Elektronik Müzik",
                    ConcertTime = "2 Mart Cumartesi",
                    ConcertLocation = "Volkswagen Arena",
                    ConcertImage = "maxresdefault.jpg"
                },
                new Concert
                {
                    Id=5,
                    ConcertName = "EVGENY GRINKO",
                    ConcertDescription = "Klasik Müzik",
                    ConcertTime = "9 Mart Cumartesi",
                    ConcertLocation = "Zorlu PSM",
                    ConcertImage = "b48f5c93c5d492fdb8c5b4108741450b.jpg"
                },
                new Concert
                {
                    Id=6,
                    ConcertName = "BERKAY",
                    ConcertDescription = "Pop Müzik",
                    ConcertTime = "10 Şubat Cumartesi",
                    ConcertLocation = "Bostancı Gösteri Merkezi",
                    ConcertImage = "ab6761610000e5ebefc7e159821a28351587cfba.jpg"
                },
                new Concert
                {
                    Id=7,
                    ConcertName = "PERDENİN ARDINDAKİLER",
                    ConcertDescription = "Alternatif Müzik",
                    ConcertTime = "18 Şubat Pazar",
                    ConcertLocation = "Bostancı Gösteri Merkezi",
                    ConcertImage = "indir (4).jpg"
                },
                new Concert
                {
                    Id=8,
                    ConcertName = "GÖKHAN TÜRKMEN",
                    ConcertDescription = "Pop Müzik",
                    ConcertTime = "9 Mart Cumartesi",
                    ConcertLocation = "Zorlu PSM",
                    ConcertImage = "ab67616d0000b273db01344ed89dc17b6062b7a3.jpg"
                }
            };
        }

        public static List<Concert> Concerts
        {
            get
            {
                return _concerts;
            }
        }

        public static Concert GetById(int id)
        {
            return _concerts.FirstOrDefault(c => c.Id == id);
        }

        public static List<Concert> FilterConcerts(string search)
        {
            search = search.ToLower();

            return _concerts.Where(concert => concert.ConcertName.ToLower().Contains(search)).ToList();
        }
    }
}
