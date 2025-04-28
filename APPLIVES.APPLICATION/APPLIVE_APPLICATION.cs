using APPLIVE.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPLIVES.APPLICATION
{
    public interface APPLIVE_APPLICATION
    {
        List<APPLIVES_ENLACES> GetAllStreams();
        APPLIVES_ENLACES GetStreamByChannel(string channelName);
    }
}
