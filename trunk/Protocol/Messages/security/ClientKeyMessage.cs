// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ClientKeyMessage.xml' the '27/06/2012 15:55:13'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class ClientKeyMessage : NetworkMessage
	{
		public const uint Id = 5607;
		public override uint MessageId
		{
			get
			{
				return 5607;
			}
		}
		
		public string key;
		
		public ClientKeyMessage()
		{
		}
		
		public ClientKeyMessage(string key)
		{
			this.key = key;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(key);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			key = reader.ReadUTF();
		}
	}
}
