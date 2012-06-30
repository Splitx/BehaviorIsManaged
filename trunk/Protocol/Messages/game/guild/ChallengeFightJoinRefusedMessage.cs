// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ChallengeFightJoinRefusedMessage.xml' the '27/06/2012 15:55:07'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class ChallengeFightJoinRefusedMessage : NetworkMessage
	{
		public const uint Id = 5908;
		public override uint MessageId
		{
			get
			{
				return 5908;
			}
		}
		
		public int playerId;
		public sbyte reason;
		
		public ChallengeFightJoinRefusedMessage()
		{
		}
		
		public ChallengeFightJoinRefusedMessage(int playerId, sbyte reason)
		{
			this.playerId = playerId;
			this.reason = reason;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(playerId);
			writer.WriteSByte(reason);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			playerId = reader.ReadInt();
			if ( playerId < 0 )
			{
				throw new Exception("Forbidden value on playerId = " + playerId + ", it doesn't respect the following condition : playerId < 0");
			}
			reason = reader.ReadSByte();
		}
	}
}
