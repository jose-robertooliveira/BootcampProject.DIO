using System;
using System.Collections.Generic;
using InternationalSeries.D.Interfaces;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalSeries.D
{
    public class RepositorySerie : IRepository<Serie>
    {
        private List<Serie> listSerie = new List<Serie>();
        public void Erase(int id)
        {
            listSerie[id].Erase();
        }

        public void Insert(Serie obj)
        {
            listSerie.Add(obj);
        }

        public List<Serie> List()
        {
            return listSerie;
        }

        public int NextId()
        {
            return listSerie.Count;
        }

        public Serie ReturnsById(int id)
        {
            return listSerie[id];
        }

        public void Update(int id, Serie obj)
        {
            listSerie[id] = obj;
        }
    }
}
