// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameActionNoopMessage.xml' the '27/06/2012 15:54:56'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class GameActionNoopMessage : NetworkMessage
	{
		public const uint Id = 1002;
		public override uint MessageId
		{
			get
			{
				return 1002;
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
