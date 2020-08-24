using Bierenapplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bierenapplication.Models;

namespace Bierenapplication.Services
{
    public class BierService
    {
        private Dictionary<int, Bier> bieren =
            new Dictionary<int, Bier>();
        public BierService()
        {
            bieren[1] = new Bier
            {
                ID = 1,
                Naam = "Kruger",
                Alcohol = 4.8F
            };
            bieren[2] = new Bier
            {
                ID = 2,
                Naam = "Duvel",
                Alcohol = 8F
            };
            bieren[3] = new Bier
            {
                ID = 3,
                Naam = "Jupiler",
                Alcohol = 5.2F
            };
            bieren[4] = new Bier
            {
                ID = 4,
                Naam = "Kasteelbier",
                Alcohol = 11F
            };
            bieren[5] = new Bier
            {
                ID = 5,
                Naam = "Augustijn",
                Alcohol = 8F
            };
        }
        public List<Bier> Findall()
        {
            return bieren.Values.ToList();
        }

        public Bier Read(int id)
        {
            return bieren[id];
        }
        public void delete(int id)
        {
            bieren.Remove(id);
        }
        public void Add(Bier p)
        {
            p.ID = bieren.Keys.Max() + 1;
            bieren.Add(p.ID, p);
        }
    }
}
