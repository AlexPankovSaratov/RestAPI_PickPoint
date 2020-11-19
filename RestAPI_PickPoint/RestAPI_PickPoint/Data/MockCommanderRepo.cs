using RestAPI_PickPoint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI_PickPoint.Data
{
    public class MockCommanderRepo : IComanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 123, name = "qwe", name2 = 999, name3 = 8888 },
                new Command { Id = 333, name = "qwe", name2 = 999, name3 = 8888 },
                new Command { Id = 553, name = "qwe", name2 = 999, name3 = 8888 }
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 123, name = "qwe", name2 = 999, name3 = 8888 };
        }
    }
}
