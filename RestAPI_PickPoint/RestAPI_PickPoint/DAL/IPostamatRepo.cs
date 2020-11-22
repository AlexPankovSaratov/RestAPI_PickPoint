using RestAPI_PickPoint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI_PickPoint.DAL
{
    public interface IPostamatRepo
    {
        IEnumerable<Postamat> GetAllPostamats();
        Postamat GetPostamatByNumber(int targetNumber);
    }
}
