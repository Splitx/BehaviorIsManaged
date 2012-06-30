// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GuildHouseRemoveMessage.xml' the '27/06/2012 15:55:07'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class GuildHouseRemoveMessage : NetworkMessage
	{
		public const uint Id = 6180;
		public override uint MessageId
		{
			get
			{
				return 6180;
			}
		}
		
		public int houseId;
		
		public GuildHouseRemoveMessage()
		{
		}
		
		public GuildHouseRemoveMessage(int houseId)
		{
			this.houseId = houseId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(houseId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			houseId = reader.ReadInt();
			if ( houseId < 0 )
			{
				throw new Exception("Forbidden value on houseId = " + houseId + ", it doesn't respect the following condition : houseId < 0");
			}
		}
	}
}
