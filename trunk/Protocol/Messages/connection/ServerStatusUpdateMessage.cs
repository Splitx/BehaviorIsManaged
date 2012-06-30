// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ServerStatusUpdateMessage.xml' the '27/06/2012 15:54:56'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class ServerStatusUpdateMessage : NetworkMessage
	{
		public const uint Id = 50;
		public override uint MessageId
		{
			get
			{
				return 50;
			}
		}
		
		public Types.GameServerInformations server;
		
		public ServerStatusUpdateMessage()
		{
		}
		
		public ServerStatusUpdateMessage(Types.GameServerInformations server)
		{
			this.server = server;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			server.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			server = new Types.GameServerInformations();
			server.Deserialize(reader);
		}
	}
}
