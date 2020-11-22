using RestAPI_PickPoint.DAL;
using RestAPI_PickPoint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI_PickPoint.BLL
{
    public class MockPostamatLogic : IPostamatLogic
    {
        private readonly IPostamatRepo _postamatRepo;
        public MockPostamatLogic(IPostamatRepo postamatRepo)
        {
            _postamatRepo = postamatRepo;
        }

        public IEnumerable<Postamat> GetAllPostamats()
        {
            return _postamatRepo.GetAllPostamats();
        }

        public Postamat GetPostamatByNumber(int targetNumber)
        {
            return _postamatRepo.GetPostamatByNumber(targetNumber);
        }
    }
}
