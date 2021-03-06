// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'MountRenamedMessage.xml' the '27/06/2012 15:55:01'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class MountRenamedMessage : NetworkMessage
	{
		public const uint Id = 5983;
		public override uint MessageId
		{
			get
			{
				return 5983;
			}
		}
		
		public double mountId;
		public string name;
		
		public MountRenamedMessage()
		{
		}
		
		public MountRenamedMessage(double mountId, string name)
		{
			this.mountId = mountId;
			this.name = name;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(mountId);
			writer.WriteUTF(name);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			mountId = reader.ReadDouble();
			name = reader.ReadUTF();
		}
	}
}
