// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'FriendAddRequestMessage.xml' the '27/06/2012 15:55:06'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class FriendAddRequestMessage : NetworkMessage
	{
		public const uint Id = 4004;
		public override uint MessageId
		{
			get
			{
				return 4004;
			}
		}
		
		public string name;
		
		public FriendAddRequestMessage()
		{
		}
		
		public FriendAddRequestMessage(string name)
		{
			this.name = name;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(name);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			name = reader.ReadUTF();
		}
	}
}
