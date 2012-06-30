// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'InventoryPresetItemUpdateErrorMessage.xml' the '27/06/2012 15:55:12'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class InventoryPresetItemUpdateErrorMessage : NetworkMessage
	{
		public const uint Id = 6211;
		public override uint MessageId
		{
			get
			{
				return 6211;
			}
		}
		
		public sbyte code;
		
		public InventoryPresetItemUpdateErrorMessage()
		{
		}
		
		public InventoryPresetItemUpdateErrorMessage(sbyte code)
		{
			this.code = code;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(code);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			code = reader.ReadSByte();
			if ( code < 0 )
			{
				throw new Exception("Forbidden value on code = " + code + ", it doesn't respect the following condition : code < 0");
			}
		}
	}
}
