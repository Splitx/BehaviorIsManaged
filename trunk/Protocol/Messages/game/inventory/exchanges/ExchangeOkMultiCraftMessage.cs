// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeOkMultiCraftMessage.xml' the '27/06/2012 15:55:10'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class ExchangeOkMultiCraftMessage : NetworkMessage
	{
		public const uint Id = 5768;
		public override uint MessageId
		{
			get
			{
				return 5768;
			}
		}
		
		public int initiatorId;
		public int otherId;
		public sbyte role;
		
		public ExchangeOkMultiCraftMessage()
		{
		}
		
		public ExchangeOkMultiCraftMessage(int initiatorId, int otherId, sbyte role)
		{
			this.initiatorId = initiatorId;
			this.otherId = otherId;
			this.role = role;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(initiatorId);
			writer.WriteInt(otherId);
			writer.WriteSByte(role);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			initiatorId = reader.ReadInt();
			if ( initiatorId < 0 )
			{
				throw new Exception("Forbidden value on initiatorId = " + initiatorId + ", it doesn't respect the following condition : initiatorId < 0");
			}
			otherId = reader.ReadInt();
			if ( otherId < 0 )
			{
				throw new Exception("Forbidden value on otherId = " + otherId + ", it doesn't respect the following condition : otherId < 0");
			}
			role = reader.ReadSByte();
		}
	}
}
