using RestAPI_PickPoint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI_PickPoint.DAL
{
    public class MockPostamatRepo : IPostamatRepo
    {
        private static List<Postamat> _AllPostamats;

        public MockPostamatRepo()
        {
            if (_AllPostamats == null)
            {
                _AllPostamats = new List<Postamat>();
                _AllPostamats.Add(new Postamat { number = 1, address = "г. Фантазия пл. Панкова д.1 кв. 777", status = true });
                _AllPostamats.Add(new Postamat { number = 2, address = "г. Фантазия ул. маршала Панкова д.17 кв. 99", status = true });
                _AllPostamats.Add(new Postamat { number = 3, address = "г. Ленинград  3-я улица Строителей, дом 25, квартира 12", status = false });
            }
        }

        public IEnumerable<Postamat> GetAllPostamats()
        {
            foreach (Postamat item in _AllPostamats)
            {
                yield return item;
            }
        }

        public Postamat GetPostamatByNumber(int targetNumber)
        {
            return _AllPostamats.FirstOrDefault(Postamat => Postamat.number == targetNumber);
        }
    }
}
