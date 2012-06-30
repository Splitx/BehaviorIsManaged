// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'PauseDialogMessage.xml' the '27/06/2012 15:55:06'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class PauseDialogMessage : NetworkMessage
	{
		public const uint Id = 6012;
		public override uint MessageId
		{
			get
			{
				return 6012;
			}
		}
		
		public sbyte dialogType;
		
		public PauseDialogMessage()
		{
		}
		
		public PauseDialogMessage(sbyte dialogType)
		{
			this.dialogType = dialogType;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(dialogType);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			dialogType = reader.ReadSByte();
			if ( dialogType < 0 )
			{
				throw new Exception("Forbidden value on dialogType = " + dialogType + ", it doesn't respect the following condition : dialogType < 0");
			}
		}
	}
}
