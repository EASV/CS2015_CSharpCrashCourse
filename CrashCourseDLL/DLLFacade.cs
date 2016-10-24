using CrashCourseDLL.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourseDLL
{
    public class DLLFacade
    {
        public IPersonManager GetPersonManager() {
            return new PersonManager();
        }
    }
}
