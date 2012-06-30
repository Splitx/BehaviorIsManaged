// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeObjectMessage.xml' the '27/06/2012 15:55:10'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class ExchangeObjectMessage : NetworkMessage
	{
		public const uint Id = 5515;
		public override uint MessageId
		{
			get
			{
				return 5515;
			}
		}
		
		public bool remote;
		
		public ExchangeObjectMessage()
		{
		}
		
		public ExchangeObjectMessage(bool remote)
		{
			this.remote = remote;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(remote);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			remote = reader.ReadBoolean();
		}
	}
}
