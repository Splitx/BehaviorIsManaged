// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeBidSearchOkMessage.xml' the '27/06/2012 15:55:09'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class ExchangeBidSearchOkMessage : NetworkMessage
	{
		public const uint Id = 5802;
		public override uint MessageId
		{
			get
			{
				return 5802;
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
