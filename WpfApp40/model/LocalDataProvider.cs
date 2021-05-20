using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp40.model
{


    public class LocalDataProvider : IDataProvider
    {
        public IEnumerable<Worker> GetWorkers()
        {
            return new Worker[]
            {
                new Worker{Surname="Николаев Николай Николаевич",Role="инженер",Year=2010, Salary=20000 },
                new Worker{Surname="Морозов Евгений Александрович", Role="сварщик", Year=2011, Salary=25000},
                new Worker{Surname="Громов Игорь Алексеевич", Role="охранник",Year=2009, Salary=24000}
            };
        }
    }
}
