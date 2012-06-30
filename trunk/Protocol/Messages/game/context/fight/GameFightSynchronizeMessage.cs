// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameFightSynchronizeMessage.xml' the '27/06/2012 15:55:00'
using System;
using BiM.Core.IO;
using System.Collections.Generic;
using System.Linq;

namespace BiM.Protocol.Messages
{
	public class GameFightSynchronizeMessage : NetworkMessage
	{
		public const uint Id = 5921;
		public override uint MessageId
		{
			get
			{
				return 5921;
			}
		}
		
		public IEnumerable<Types.GameFightFighterInformations> fighters;
		
		public GameFightSynchronizeMessage()
		{
		}
		
		public GameFightSynchronizeMessage(IEnumerable<Types.GameFightFighterInformations> fighters)
		{
			this.fighters = fighters;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUShort((ushort)fighters.Count());
			foreach (var entry in fighters)
			{
				writer.WriteShort(entry.TypeId);
				entry.Serialize(writer);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			int limit = reader.ReadUShort();
			fighters = new Types.GameFightFighterInformations[limit];
			for (int i = 0; i < limit; i++)
			{
				(fighters as Types.GameFightFighterInformations[])[i] = Types.ProtocolTypeManager.GetInstance<Types.GameFightFighterInformations>(reader.ReadShort());
				(fighters as Types.GameFightFighterInformations[])[i].Deserialize(reader);
			}
		}
	}
}
