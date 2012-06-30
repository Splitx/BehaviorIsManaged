// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'CharacterStatsListMessage.xml' the '27/06/2012 15:54:59'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class CharacterStatsListMessage : NetworkMessage
	{
		public const uint Id = 500;
		public override uint MessageId
		{
			get
			{
				return 500;
			}
		}
		
		public Types.CharacterCharacteristicsInformations stats;
		
		public CharacterStatsListMessage()
		{
		}
		
		public CharacterStatsListMessage(Types.CharacterCharacteristicsInformations stats)
		{
			this.stats = stats;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			stats.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			stats = new Types.CharacterCharacteristicsInformations();
			stats.Deserialize(reader);
		}
	}
}
