﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreecraftCore.Serializer;

namespace Booma.Proxy
{
	/// <summary>
	/// Redirects the client to a new IPAddress:Port
	/// </summary>
	[WireDataContract]
	[PatchServerPacketPayload(PatchNetworkOperationCode.PATCH_REDIRECT_TYPE)]
	public sealed class PatchingRedirectPayload : PSOBBPatchPacketPayloadServer
	{
		/// <summary>
		/// IP Address bytes
		/// </summary>
		[KnownSize(4)]
		[WireMember(1)]
		public byte[] IPAddress { get; }

		/// <summary>
		/// Port
		/// </summary>
		[ReverseData]
		[WireMember(2)]
		public ushort Port { get; }

		public PatchingRedirectPayload(byte[] ipAddress, ushort port)
		{
			if (ipAddress == null) throw new ArgumentNullException(nameof(ipAddress));
			if (ipAddress.Length != 4) throw new ArgumentException("IP Address must be 4 bytes long", nameof(ipAddress));
			if (port > ushort.MaxValue) throw new ArgumentOutOfRangeException("Port cannot be higher than 65535.", nameof(port));

			IPAddress = ipAddress;
			Port = port;
		}

		public PatchingRedirectPayload(byte[] ipAddress, int port) : this(ipAddress, (ushort)port)
		{
		}

		//Serializer ctor
		private PatchingRedirectPayload()
		{

		}
	}
}
