// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeStartAsVendorMessage.xml' the '27/06/2012 15:55:10'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class ExchangeStartAsVendorMessage : NetworkMessage
	{
		public const uint Id = 5775;
		public override uint MessageId
		{
			get
			{
				return 5775;
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
