using System;
using Smod2.EventHandlers;
using Smod2.Events;

namespace jsmod2
{
    public class HandleBan : IEventHandlerBan
    {
        void IEventHandlerBan.OnBan(BanEvent ev)
        {
            ProxyHandler.handler.sendEventObject(ev,0x04,
                new IdMapping()
                    .appendId(Lib.ID,Guid.NewGuid().ToString())
                .appendId(Lib.PLAYER_EVENT_SCPDATA_ID,Guid.NewGuid().ToString())
                .appendId(Lib.ADMIN_EVENT_SCPDATA_ID,Guid.NewGuid().ToString())
            );
        }
    }
}