using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56_SOLIDPrensipleri._05_DependencyInversion.GoodImplementation
{
    public class SqlService
    {
        private readonly IRepository _repo;

        public SqlService(IRepository repo)
        {
            _repo = repo;
        }

        void Save()
        {
            _repo.Save();
        }
    }
}
