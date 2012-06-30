// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeMountStableAddMessage.xml' the '27/06/2012 15:55:09'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class ExchangeMountStableAddMessage : NetworkMessage
	{
		public const uint Id = 5971;
		public override uint MessageId
		{
			get
			{
				return 5971;
			}
		}
		
		public Types.MountClientData mountDescription;
		
		public ExchangeMountStableAddMessage()
		{
		}
		
		public ExchangeMountStableAddMessage(Types.MountClientData mountDescription)
		{
			this.mountDescription = mountDescription;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			mountDescription.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			mountDescription = new Types.MountClientData();
			mountDescription.Deserialize(reader);
		}
	}
}
