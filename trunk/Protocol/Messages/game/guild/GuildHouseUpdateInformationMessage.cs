// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GuildHouseUpdateInformationMessage.xml' the '27/06/2012 15:55:07'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class GuildHouseUpdateInformationMessage : NetworkMessage
	{
		public const uint Id = 6181;
		public override uint MessageId
		{
			get
			{
				return 6181;
			}
		}
		
		public Types.HouseInformationsForGuild housesInformations;
		
		public GuildHouseUpdateInformationMessage()
		{
		}
		
		public GuildHouseUpdateInformationMessage(Types.HouseInformationsForGuild housesInformations)
		{
			this.housesInformations = housesInformations;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			housesInformations.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			housesInformations = new Types.HouseInformationsForGuild();
			housesInformations.Deserialize(reader);
		}
	}
}
