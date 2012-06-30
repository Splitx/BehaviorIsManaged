// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeShopStockMovementRemovedMessage.xml' the '27/06/2012 15:55:10'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class ExchangeShopStockMovementRemovedMessage : NetworkMessage
	{
		public const uint Id = 5907;
		public override uint MessageId
		{
			get
			{
				return 5907;
			}
		}
		
		public int objectId;
		
		public ExchangeShopStockMovementRemovedMessage()
		{
		}
		
		public ExchangeShopStockMovementRemovedMessage(int objectId)
		{
			this.objectId = objectId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(objectId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			objectId = reader.ReadInt();
			if ( objectId < 0 )
			{
				throw new Exception("Forbidden value on objectId = " + objectId + ", it doesn't respect the following condition : objectId < 0");
			}
		}
	}
}
