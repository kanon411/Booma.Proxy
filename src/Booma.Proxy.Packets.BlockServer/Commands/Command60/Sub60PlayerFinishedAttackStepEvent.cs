﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreecraftCore.Serializer;

namespace Booma.Proxy
{
	//https://sylverant.net/wiki/index.php/Packet_0x60#Subcommand_0x46
	/// <summary>
	/// Packet sent when an attack step is completed by a client.
	/// </summary>
	[WireDataContract]
	[SubCommand60(SubCommand60OperationCode.AttackStepFinished)]
	public sealed class Sub60PlayerFinishedAttackStepEvent : BaseSubCommand60, IMessageContextIdentifiable, ISerializationEventListener
	{
		//TODO: I haven't verified that this is the identifier for the client BUT it probably has to be.
		/// <inheritdoc />
		[WireMember(1)]
		public byte Identifier { get; }

		[WireMember(2)]
		private byte unk1 { get; }
		
		[SendSize(SendSizeAttribute.SizeType.UShort)]
		[WireMember(3)]
		private AttackHitResult[] _HitResults { get; }

		/// <summary>
		/// The results of an attack hit.
		/// </summary>
		public IEnumerable<AttackHitResult> HitResults => _HitResults;

		/// <summary>
		/// Indicates if the attack missed.
		/// </summary>
		public bool isAttackMissed => _HitResults == null || _HitResults.Length == 0;

		//TODO: What is the last two bytes of this packet? Seems always 0, not from crypto padding.
		[WireMember(4)]
		private short unk2 { get; } = 0;

		/// <inheritdoc />
		public Sub60PlayerFinishedAttackStepEvent(byte identifier, params AttackHitResult[] hitResults)
		{
			Identifier = identifier;
			_HitResults = hitResults;

			//We only set the command header before serialization because
			//it's dynamic and can't be statically set and is only needed when we're about to serialize
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		private Sub60PlayerFinishedAttackStepEvent()
		{
			//We only set the command header before serialization because
			//it's dynamic and can't be statically set and is only needed when we're about to serialize
		}

		/// <inheritdoc />
		public void OnBeforeSerialization()
		{
			//Command size is header size + payload size /4
			//header + lengthprefix size + hits size + final 2 bytes + 2 to avoid truncation
			CommandSize = (byte)((2 + 2 + (_HitResults?.Length * 4 ?? 0) + 2 + 2) / 4);
		}

		/// <inheritdoc />
		public void OnAfterDeserialization()
		{

		}
	}
}
