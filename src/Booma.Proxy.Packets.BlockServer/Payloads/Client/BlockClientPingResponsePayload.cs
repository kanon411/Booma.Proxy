﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreecraftCore.Serializer;

namespace Booma.Proxy
{
	/// <summary>
	/// Ping response the client sends when it recieves the ping event <see cref="BlockClientPingEventPayload"/>
	/// from the server. This must be sent as a reply otherwise we will disconnect.
	/// </summary>
	[WireDataContract]
	[GameClientPacketPayload(GameNetworkOperationCode.PING_TYPE)]
	public sealed class BlockClientPingResponsePayload : PSOBBGamePacketPayloadClient
	{
		//Just empty response to the ping
		public BlockClientPingResponsePayload()
		{
			
		}
	}
}
