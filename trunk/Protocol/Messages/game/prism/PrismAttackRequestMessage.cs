// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'PrismAttackRequestMessage.xml' the '27/06/2012 15:55:12'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class PrismAttackRequestMessage : NetworkMessage
	{
		public const uint Id = 6042;
		public override uint MessageId
		{
			get
			{
				return 6042;
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
