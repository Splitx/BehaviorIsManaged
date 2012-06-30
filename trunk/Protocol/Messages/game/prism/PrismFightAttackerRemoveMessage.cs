// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'PrismFightAttackerRemoveMessage.xml' the '27/06/2012 15:55:12'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class PrismFightAttackerRemoveMessage : NetworkMessage
	{
		public const uint Id = 5897;
		public override uint MessageId
		{
			get
			{
				return 5897;
			}
		}
		
		public double fightId;
		public int fighterToRemoveId;
		
		public PrismFightAttackerRemoveMessage()
		{
		}
		
		public PrismFightAttackerRemoveMessage(double fightId, int fighterToRemoveId)
		{
			this.fightId = fightId;
			this.fighterToRemoveId = fighterToRemoveId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(fightId);
			writer.WriteInt(fighterToRemoveId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			fightId = reader.ReadDouble();
			fighterToRemoveId = reader.ReadInt();
			if ( fighterToRemoveId < 0 )
			{
				throw new Exception("Forbidden value on fighterToRemoveId = " + fighterToRemoveId + ", it doesn't respect the following condition : fighterToRemoveId < 0");
			}
		}
	}
}
