// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeStartOkMountMessage.xml' the '27/06/2012 15:55:10'
using System;
using BiM.Core.IO;
using System.Collections.Generic;
using System.Linq;

namespace BiM.Protocol.Messages
{
	public class ExchangeStartOkMountMessage : ExchangeStartOkMountWithOutPaddockMessage
	{
		public const uint Id = 5979;
		public override uint MessageId
		{
			get
			{
				return 5979;
			}
		}
		
		public IEnumerable<Types.MountClientData> paddockedMountsDescription;
		
		public ExchangeStartOkMountMessage()
		{
		}
		
		public ExchangeStartOkMountMessage(IEnumerable<Types.MountClientData> stabledMountsDescription, IEnumerable<Types.MountClientData> paddockedMountsDescription)
			 : base(stabledMountsDescription)
		{
			this.paddockedMountsDescription = paddockedMountsDescription;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUShort((ushort)paddockedMountsDescription.Count());
			foreach (var entry in paddockedMountsDescription)
			{
				entry.Serialize(writer);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			int limit = reader.ReadUShort();
			paddockedMountsDescription = new Types.MountClientData[limit];
			for (int i = 0; i < limit; i++)
			{
				(paddockedMountsDescription as Types.MountClientData[])[i] = new Types.MountClientData();
				(paddockedMountsDescription as Types.MountClientData[])[i].Deserialize(reader);
			}
		}
	}
}
