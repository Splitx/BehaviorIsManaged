// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'MapRunningFightListRequestMessage.xml' the '27/06/2012 15:55:02'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class MapRunningFightListRequestMessage : NetworkMessage
	{
		public const uint Id = 5742;
		public override uint MessageId
		{
			get
			{
				return 5742;
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
