﻿using FreecraftCore.Serializer;

namespace Booma.Proxy
{
	[WireDataContract]
	public sealed class TechniqueDefinitionData
	{
		//TODO: Might be a byte, the next byte might actually do something.
		//TODO: Make technique enum
		[WireMember(1)]
		public short TechniqueId { get; }

		//When sent over the network this is Level - 1
		/// <summary>
		/// The level of the technique being cast.
		/// </summary>
		[WireMember(2)]
		public byte Level { get; }

		/// <inheritdoc />
		public TechniqueDefinitionData(short techniqueId, byte level)
		{
			TechniqueId = techniqueId;
			Level = level;
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		private TechniqueDefinitionData()
		{
			
		}
	}
}