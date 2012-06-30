// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameRolePlayArenaFightAnswerMessage.xml' the '27/06/2012 15:55:02'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class GameRolePlayArenaFightAnswerMessage : NetworkMessage
	{
		public const uint Id = 6279;
		public override uint MessageId
		{
			get
			{
				return 6279;
			}
		}
		
		public int fightId;
		public bool accept;
		
		public GameRolePlayArenaFightAnswerMessage()
		{
		}
		
		public GameRolePlayArenaFightAnswerMessage(int fightId, bool accept)
		{
			this.fightId = fightId;
			this.accept = accept;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(fightId);
			writer.WriteBoolean(accept);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			fightId = reader.ReadInt();
			accept = reader.ReadBoolean();
		}
	}
}