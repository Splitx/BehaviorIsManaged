// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GuildFightPlayersEnemyRemoveMessage.xml' the '27/06/2012 15:55:08'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class GuildFightPlayersEnemyRemoveMessage : NetworkMessage
	{
		public const uint Id = 5929;
		public override uint MessageId
		{
			get
			{
				return 5929;
			}
		}
		
		public double fightId;
		public int playerId;
		
		public GuildFightPlayersEnemyRemoveMessage()
		{
		}
		
		public GuildFightPlayersEnemyRemoveMessage(double fightId, int playerId)
		{
			this.fightId = fightId;
			this.playerId = playerId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(fightId);
			writer.WriteInt(playerId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			fightId = reader.ReadDouble();
			if ( fightId < 0 )
			{
				throw new Exception("Forbidden value on fightId = " + fightId + ", it doesn't respect the following condition : fightId < 0");
			}
			playerId = reader.ReadInt();
			if ( playerId < 0 )
			{
				throw new Exception("Forbidden value on playerId = " + playerId + ", it doesn't respect the following condition : playerId < 0");
			}
		}
	}
}
