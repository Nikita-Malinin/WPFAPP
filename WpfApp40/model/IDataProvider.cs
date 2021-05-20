using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp40.model
{
    interface IDataProvider
    {
        IEnumerable<Worker> GetWorkers();
    }
}
