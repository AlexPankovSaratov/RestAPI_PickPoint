using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RestAPI_PickPoint.Tools
{
    enum ErrorStatuses : int
    {
        OK = 200,
        NotFound = 404,
        BadRequest = 400,
        Forbidden = 403
    }
    public static class Tools
    {
        public static bool PhoneNumberCorrect(string number)
        {
            if (number.Length != 15) return false;
            Regex regex = new Regex(@"\+7[0-9]{3}-[0-9]{3}-[0-9]{2}-[0-9]{2}");
            return regex.IsMatch(number);
        }
    }
}
