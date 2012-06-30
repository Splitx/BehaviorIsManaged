// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ShowCellMessage.xml' the '27/06/2012 15:55:00'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class ShowCellMessage : NetworkMessage
	{
		public const uint Id = 5612;
		public override uint MessageId
		{
			get
			{
				return 5612;
			}
		}
		
		public int sourceId;
		public short cellId;
		
		public ShowCellMessage()
		{
		}
		
		public ShowCellMessage(int sourceId, short cellId)
		{
			this.sourceId = sourceId;
			this.cellId = cellId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(sourceId);
			writer.WriteShort(cellId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			sourceId = reader.ReadInt();
			cellId = reader.ReadShort();
			if ( cellId < 0 || cellId > 559 )
			{
				throw new Exception("Forbidden value on cellId = " + cellId + ", it doesn't respect the following condition : cellId < 0 || cellId > 559");
			}
		}
	}
}
