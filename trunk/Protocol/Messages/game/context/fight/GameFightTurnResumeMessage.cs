// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameFightTurnResumeMessage.xml' the '27/06/2012 15:55:01'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class GameFightTurnResumeMessage : GameFightTurnStartMessage
	{
		public const uint Id = 6307;
		public override uint MessageId
		{
			get
			{
				return 6307;
			}
		}
		
		
		public GameFightTurnResumeMessage()
		{
		}
		
		public GameFightTurnResumeMessage(int id, int waitTime)
			 : base(id, waitTime)
		{
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
		}
	}
}
