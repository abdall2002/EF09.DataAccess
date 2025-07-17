using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcludeEntities.Entities
{
    public class Snapshot
    {
        public DateTime LoadedAt => DateTime.UtcNow;
        public String Version =>
            Guid.NewGuid().ToString().Substring(0, 8); // 81604D1D
    }
}
