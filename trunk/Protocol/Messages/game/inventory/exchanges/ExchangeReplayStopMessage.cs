// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeReplayStopMessage.xml' the '27/06/2012 15:55:10'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class ExchangeReplayStopMessage : NetworkMessage
	{
		public const uint Id = 6001;
		public override uint MessageId
		{
			get
			{
				return 6001;
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
