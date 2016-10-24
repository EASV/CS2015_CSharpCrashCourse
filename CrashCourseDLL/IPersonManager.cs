using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourseDLL
{
    public interface IPersonManager
    {
        List<Person> GetPersons();

        Person CreatePerson(Person p);
    }
}
