using System;
using Smod2.EventHandlers;
using Smod2.Events;

namespace jsmod2
{
    public class HandlePickupItem : IEventHandlerPlayerPickupItem
    {
        void IEventHandlerPlayerPickupItem.OnPlayerPickupItem(PlayerPickupItemEvent ev)
        {
            ProxyHandler.handler.sendEventObject(ev,0x31,new IdMapping()
                .appendId(Lib.ID,Guid.NewGuid().ToString(),ev)
                .appendId(Lib.PLAYER_ID,Guid.NewGuid().ToString(),ev.Player)
                .appendId(Lib.PLAYER_EVENT_SCPDATA_ID,Guid.NewGuid().ToString(),ev.Player.Scp079Data)
                .appendId(Lib.ITEM_EVENT_ID,Guid.NewGuid().ToString(),ev.Item)
            );
        }
    }
}