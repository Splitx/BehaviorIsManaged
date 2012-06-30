// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'AcquaintanceSearchErrorMessage.xml' the '27/06/2012 15:54:56'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class AcquaintanceSearchErrorMessage : NetworkMessage
	{
		public const uint Id = 6143;
		public override uint MessageId
		{
			get
			{
				return 6143;
			}
		}
		
		public sbyte reason;
		
		public AcquaintanceSearchErrorMessage()
		{
		}
		
		public AcquaintanceSearchErrorMessage(sbyte reason)
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
			if ( reason < 0 )
			{
				throw new Exception("Forbidden value on reason = " + reason + ", it doesn't respect the following condition : reason < 0");
			}
		}
	}
}
