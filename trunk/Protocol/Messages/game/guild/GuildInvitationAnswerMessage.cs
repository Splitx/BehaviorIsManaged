// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GuildInvitationAnswerMessage.xml' the '27/06/2012 15:55:07'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class GuildInvitationAnswerMessage : NetworkMessage
	{
		public const uint Id = 5556;
		public override uint MessageId
		{
			get
			{
				return 5556;
			}
		}
		
		public bool accept;
		
		public GuildInvitationAnswerMessage()
		{
		}
		
		public GuildInvitationAnswerMessage(bool accept)
		{
			this.accept = accept;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(accept);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			accept = reader.ReadBoolean();
		}
	}
}
