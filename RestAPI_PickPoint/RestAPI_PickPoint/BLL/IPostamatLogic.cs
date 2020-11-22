using RestAPI_PickPoint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI_PickPoint.BLL
{
    public interface IPostamatLogic
    {
        IEnumerable<Postamat> GetAllPostamats();
        Postamat GetPostamatByNumber(int targetNumber);
    }
}
