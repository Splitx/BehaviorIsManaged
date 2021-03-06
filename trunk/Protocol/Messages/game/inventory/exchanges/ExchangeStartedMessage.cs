// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeStartedMessage.xml' the '27/06/2012 15:55:10'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class ExchangeStartedMessage : NetworkMessage
	{
		public const uint Id = 5512;
		public override uint MessageId
		{
			get
			{
				return 5512;
			}
		}
		
		public sbyte exchangeType;
		
		public ExchangeStartedMessage()
		{
		}
		
		public ExchangeStartedMessage(sbyte exchangeType)
		{
			this.exchangeType = exchangeType;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(exchangeType);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			exchangeType = reader.ReadSByte();
		}
	}
}
