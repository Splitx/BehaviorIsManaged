// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameRolePlayFreeSoulRequestMessage.xml' the '27/06/2012 15:55:02'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class GameRolePlayFreeSoulRequestMessage : NetworkMessage
	{
		public const uint Id = 745;
		public override uint MessageId
		{
			get
			{
				return 745;
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
