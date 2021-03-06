// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'JobCrafterDirectoryEntryMessage.xml' the '27/06/2012 15:55:03'
using System;
using BiM.Core.IO;
using System.Collections.Generic;
using System.Linq;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class JobCrafterDirectoryEntryMessage : NetworkMessage
	{
		public const uint Id = 6044;
		public override uint MessageId
		{
			get
			{
				return 6044;
			}
		}
		
		public Types.JobCrafterDirectoryEntryPlayerInfo playerInfo;
		public Types.JobCrafterDirectoryEntryJobInfo[] jobInfoList;
		public Types.EntityLook playerLook;
		
		public JobCrafterDirectoryEntryMessage()
		{
		}
		
		public JobCrafterDirectoryEntryMessage(Types.JobCrafterDirectoryEntryPlayerInfo playerInfo, Types.JobCrafterDirectoryEntryJobInfo[] jobInfoList, Types.EntityLook playerLook)
		{
			this.playerInfo = playerInfo;
			this.jobInfoList = jobInfoList;
			this.playerLook = playerLook;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			playerInfo.Serialize(writer);
			writer.WriteUShort((ushort)jobInfoList.Count());
			foreach (var entry in jobInfoList)
			{
				entry.Serialize(writer);
			}
			playerLook.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			playerInfo = new Types.JobCrafterDirectoryEntryPlayerInfo();
			playerInfo.Deserialize(reader);
			int limit = reader.ReadUShort();
			jobInfoList = new Types.JobCrafterDirectoryEntryJobInfo[limit];
			for (int i = 0; i < limit; i++)
			{
				(jobInfoList as Types.JobCrafterDirectoryEntryJobInfo[])[i] = new Types.JobCrafterDirectoryEntryJobInfo();
				(jobInfoList as Types.JobCrafterDirectoryEntryJobInfo[])[i].Deserialize(reader);
			}
			playerLook = new Types.EntityLook();
			playerLook.Deserialize(reader);
		}
	}
}
