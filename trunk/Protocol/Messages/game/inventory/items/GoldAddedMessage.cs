// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GoldAddedMessage.xml' the '27/06/2012 15:55:11'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class GoldAddedMessage : NetworkMessage
	{
		public const uint Id = 6030;
		public override uint MessageId
		{
			get
			{
				return 6030;
			}
		}
		
		public Types.GoldItem gold;
		
		public GoldAddedMessage()
		{
		}
		
		public GoldAddedMessage(Types.GoldItem gold)
		{
			this.gold = gold;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			gold.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			gold = new Types.GoldItem();
			gold.Deserialize(reader);
		}
	}
}
