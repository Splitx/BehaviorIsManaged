// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeCraftResultMessage.xml' the '27/06/2012 15:55:09'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class ExchangeCraftResultMessage : NetworkMessage
	{
		public const uint Id = 5790;
		public override uint MessageId
		{
			get
			{
				return 5790;
			}
		}
		
		public sbyte craftResult;
		
		public ExchangeCraftResultMessage()
		{
		}
		
		public ExchangeCraftResultMessage(sbyte craftResult)
		{
			this.craftResult = craftResult;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(craftResult);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			craftResult = reader.ReadSByte();
			if ( craftResult < 0 )
			{
				throw new Exception("Forbidden value on craftResult = " + craftResult + ", it doesn't respect the following condition : craftResult < 0");
			}
		}
	}
}
