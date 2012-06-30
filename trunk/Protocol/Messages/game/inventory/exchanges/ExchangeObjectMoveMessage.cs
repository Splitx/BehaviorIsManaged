// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeObjectMoveMessage.xml' the '27/06/2012 15:55:10'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class ExchangeObjectMoveMessage : NetworkMessage
	{
		public const uint Id = 5518;
		public override uint MessageId
		{
			get
			{
				return 5518;
			}
		}
		
		public int objectUID;
		public int quantity;
		
		public ExchangeObjectMoveMessage()
		{
		}
		
		public ExchangeObjectMoveMessage(int objectUID, int quantity)
		{
			this.objectUID = objectUID;
			this.quantity = quantity;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(objectUID);
			writer.WriteInt(quantity);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			objectUID = reader.ReadInt();
			if ( objectUID < 0 )
			{
				throw new Exception("Forbidden value on objectUID = " + objectUID + ", it doesn't respect the following condition : objectUID < 0");
			}
			quantity = reader.ReadInt();
		}
	}
}
