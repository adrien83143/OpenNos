﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)
using OpenNos.Core;

namespace OpenNos.GameObject
{
    [PacketHeader("get")]
    public class GetPacket : PacketDefinition
    {
        #region Properties        

        [PacketIndex(2)]
        public long TransportId { get; set; }

        #endregion
    }
}