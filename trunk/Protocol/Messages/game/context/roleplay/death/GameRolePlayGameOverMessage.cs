// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameRolePlayGameOverMessage.xml' the '27/06/2012 15:55:02'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class GameRolePlayGameOverMessage : NetworkMessage
	{
		public const uint Id = 746;
		public override uint MessageId
		{
			get
			{
				return 746;
			}
		}
		
		
		public override void Serialize(IDataWriter writer)
		{
		}
		
		public override void Deserialize(IDataReader reader)
		{
		}
	}
}
