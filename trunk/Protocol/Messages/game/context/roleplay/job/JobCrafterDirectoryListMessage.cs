// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'JobCrafterDirectoryListMessage.xml' the '27/06/2012 15:55:03'
using System;
using BiM.Core.IO;
using System.Collections.Generic;
using System.Linq;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class JobCrafterDirectoryListMessage : NetworkMessage
	{
		public const uint Id = 6046;
		public override uint MessageId
		{
			get
			{
				return 6046;
			}
		}
		
		public Types.JobCrafterDirectoryListEntry[] listEntries;
		
		public JobCrafterDirectoryListMessage()
		{
		}
		
		public JobCrafterDirectoryListMessage(Types.JobCrafterDirectoryListEntry[] listEntries)
		{
			this.listEntries = listEntries;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUShort((ushort)listEntries.Count());
			foreach (var entry in listEntries)
			{
				entry.Serialize(writer);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			int limit = reader.ReadUShort();
			listEntries = new Types.JobCrafterDirectoryListEntry[limit];
			for (int i = 0; i < limit; i++)
			{
				(listEntries as Types.JobCrafterDirectoryListEntry[])[i] = new Types.JobCrafterDirectoryListEntry();
				(listEntries as Types.JobCrafterDirectoryListEntry[])[i].Deserialize(reader);
			}
		}
	}
}
