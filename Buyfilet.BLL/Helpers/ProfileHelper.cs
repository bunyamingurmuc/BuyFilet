using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Buyfilet.BLL.Mappings.AutoMapper;

namespace Buyfilet.BLL.Helpers
{
    public static class ProfileHelper
    {
        public static List<Profile> GetPorfiles()
        {
            return new List<Profile>
            {
                new BFUserProfile(),
                new Profiles(),

            };
        }

    }
}
