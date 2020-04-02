using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fengaspnecore
{
    public class eUser:IdentityUser
    {
        public int feng { set; get; }
    }
}
