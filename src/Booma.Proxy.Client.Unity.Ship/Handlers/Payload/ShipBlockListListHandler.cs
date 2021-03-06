﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GladNet;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using UnityEngine;
using UnityEngine.Events;

namespace Booma.Proxy
{
	/// <summary>
	/// Handles <see cref="ShipBlockListEventPayload"/> and dispatches to the
	/// UI controller service.
	/// </summary>
	public sealed class ShipBlockListListHandler : GameMessageHandler<ShipBlockListEventPayload>
	{
		/// <summary>
		/// The menu registeration service.
		/// </summary>
		[Required]
		[OdinSerialize]
		private IMenuListingRegisterable BlockListingRegisterService { get; set; }

		[SerializeField]
		private UnityEvent OnRecievedBlockList;

		/// <inheritdoc />
		public override Task HandleMessage(IPeerMessageContext<PSOBBGamePacketPayloadClient> context, ShipBlockListEventPayload payload)
		{
			foreach(MenuListing m in payload.Blocks)
			{
				if(Logger.IsDebugEnabled)
					Logger.Debug($"Block Listing: {m.ItemName}");

				BlockListingRegisterService.RegisterMenuItem(m);
			}

			//Once it's completely registered invoke OnRecieved.
			OnRecievedBlockList?.Invoke();

			return Task.CompletedTask;
		}
	}
}
