﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GladNet;
using SceneJect.Common;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using UnityEngine;

namespace Booma.Proxy
{
	/// <summary>
	/// Handler that deals with the <see cref="Sub60MovingFastPositionSetCommand"/>
	/// event that is raised by the server when a client is moving fast/running.
	/// </summary>
	[Injectee]
	public sealed class BlockMovingFastPositionChangedEventHandler : ContextExtendedCommand60Handler<Sub60MovingFastPositionSetCommand, INetworkPlayerNetworkMessageContext>
	{
		/// <summary>
		/// Service that translates the incoming position to the correct unit scale that
		/// Unity3D expects.
		/// </summary>
		[Inject]
		private IUnitScalerStrategy Scaler { get; }

		/// <inheritdoc />
		protected override Task HandleSubMessage(IPeerMessageContext<PSOBBGamePacketPayloadClient> context, Sub60MovingFastPositionSetCommand command, INetworkPlayerNetworkMessageContext commandContext)
		{
			Vector2 position = Scaler.ScaleYasZ(command.Position);

			//Set the position of the network transform
			commandContext.RemotePlayer.Transform.Position = new Vector3(position.x, commandContext.RemotePlayer.Transform.Position.y, position.y);

			return Task.CompletedTask;
		}
	}
}
