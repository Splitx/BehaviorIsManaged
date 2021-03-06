// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeTypesItemsExchangerDescriptionForUserMessage.xml' the '27/06/2012 15:55:11'
using System;
using BiM.Core.IO;
using System.Collections.Generic;
using System.Linq;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class ExchangeTypesItemsExchangerDescriptionForUserMessage : NetworkMessage
	{
		public const uint Id = 5752;
		public override uint MessageId
		{
			get
			{
				return 5752;
			}
		}
		
		public Types.BidExchangerObjectInfo[] itemTypeDescriptions;
		
		public ExchangeTypesItemsExchangerDescriptionForUserMessage()
		{
		}
		
		public ExchangeTypesItemsExchangerDescriptionForUserMessage(Types.BidExchangerObjectInfo[] itemTypeDescriptions)
		{
			this.itemTypeDescriptions = itemTypeDescriptions;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUShort((ushort)itemTypeDescriptions.Count());
			foreach (var entry in itemTypeDescriptions)
			{
				entry.Serialize(writer);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			int limit = reader.ReadUShort();
			itemTypeDescriptions = new Types.BidExchangerObjectInfo[limit];
			for (int i = 0; i < limit; i++)
			{
				(itemTypeDescriptions as Types.BidExchangerObjectInfo[])[i] = new Types.BidExchangerObjectInfo();
				(itemTypeDescriptions as Types.BidExchangerObjectInfo[])[i].Deserialize(reader);
			}
		}
	}
}
