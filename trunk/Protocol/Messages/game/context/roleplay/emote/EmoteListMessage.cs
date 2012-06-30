// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'EmoteListMessage.xml' the '27/06/2012 15:55:02'
using System;
using BiM.Core.IO;
using System.Collections.Generic;
using System.Linq;

namespace BiM.Protocol.Messages
{
	public class EmoteListMessage : NetworkMessage
	{
		public const uint Id = 5689;
		public override uint MessageId
		{
			get
			{
				return 5689;
			}
		}
		
		public IEnumerable<sbyte> emoteIds;
		
		public EmoteListMessage()
		{
		}
		
		public EmoteListMessage(IEnumerable<sbyte> emoteIds)
		{
			this.emoteIds = emoteIds;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUShort((ushort)emoteIds.Count());
			foreach (var entry in emoteIds)
			{
				writer.WriteSByte(entry);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			int limit = reader.ReadUShort();
			emoteIds = new sbyte[limit];
			for (int i = 0; i < limit; i++)
			{
				(emoteIds as sbyte[])[i] = reader.ReadSByte();
			}
		}
	}
}
