// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeAcceptMessage.xml' the '27/06/2012 15:55:09'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class ExchangeAcceptMessage : NetworkMessage
	{
		public const uint Id = 5508;
		public override uint MessageId
		{
			get
			{
				return 5508;
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
