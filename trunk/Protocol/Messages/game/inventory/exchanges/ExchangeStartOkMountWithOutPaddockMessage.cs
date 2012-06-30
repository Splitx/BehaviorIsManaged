// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeStartOkMountWithOutPaddockMessage.xml' the '27/06/2012 15:55:11'
using System;
using BiM.Core.IO;
using System.Collections.Generic;
using System.Linq;

namespace BiM.Protocol.Messages
{
	public class ExchangeStartOkMountWithOutPaddockMessage : NetworkMessage
	{
		public const uint Id = 5991;
		public override uint MessageId
		{
			get
			{
				return 5991;
			}
		}
		
		public IEnumerable<Types.MountClientData> stabledMountsDescription;
		
		public ExchangeStartOkMountWithOutPaddockMessage()
		{
		}
		
		public ExchangeStartOkMountWithOutPaddockMessage(IEnumerable<Types.MountClientData> stabledMountsDescription)
		{
			this.stabledMountsDescription = stabledMountsDescription;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUShort((ushort)stabledMountsDescription.Count());
			foreach (var entry in stabledMountsDescription)
			{
				entry.Serialize(writer);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			int limit = reader.ReadUShort();
			stabledMountsDescription = new Types.MountClientData[limit];
			for (int i = 0; i < limit; i++)
			{
				(stabledMountsDescription as Types.MountClientData[])[i] = new Types.MountClientData();
				(stabledMountsDescription as Types.MountClientData[])[i].Deserialize(reader);
			}
		}
	}
}
