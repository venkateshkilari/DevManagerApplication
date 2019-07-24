using BusinessEntity.Interface.Devops;
using System.Collections.Generic;

namespace BusinessEntity.Implementation.Devops
{
    public class DevopsBE:EntityBE<string>,IDevopsBE
    {
        public List<ServerBE> Servers { get; set; }
    }
}
