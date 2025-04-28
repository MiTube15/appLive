using APPLIVE.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace APPLIVES.APPLICATION
{
    public interface APPLIVE_IIptvService
    {
        Task<List<APPI_CHANELS>> GetChannelsAsync(string category=null, string country=null, string search=null);
    }
}
