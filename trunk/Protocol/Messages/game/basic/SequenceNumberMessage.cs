// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'SequenceNumberMessage.xml' the '27/06/2012 15:54:58'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class SequenceNumberMessage : NetworkMessage
	{
		public const uint Id = 6317;
		public override uint MessageId
		{
			get
			{
				return 6317;
			}
		}
		
		public ushort number;
		
		public SequenceNumberMessage()
		{
		}
		
		public SequenceNumberMessage(ushort number)
		{
			this.number = number;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUShort(number);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			number = reader.ReadUShort();
			if ( number < 0 || number > 65535 )
			{
				throw new Exception("Forbidden value on number = " + number + ", it doesn't respect the following condition : number < 0 || number > 65535");
			}
		}
	}
}
