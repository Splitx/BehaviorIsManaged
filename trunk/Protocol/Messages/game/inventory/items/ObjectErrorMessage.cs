// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ObjectErrorMessage.xml' the '27/06/2012 15:55:11'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class ObjectErrorMessage : NetworkMessage
	{
		public const uint Id = 3004;
		public override uint MessageId
		{
			get
			{
				return 3004;
			}
		}
		
		public sbyte reason;
		
		public ObjectErrorMessage()
		{
		}
		
		public ObjectErrorMessage(sbyte reason)
		{
			this.reason = reason;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(reason);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			reason = reader.ReadSByte();
		}
	}
}
