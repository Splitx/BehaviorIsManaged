// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeLeaveMessage.xml' the '27/06/2012 15:55:09'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class ExchangeLeaveMessage : LeaveDialogMessage
	{
		public const uint Id = 5628;
		public override uint MessageId
		{
			get
			{
				return 5628;
			}
		}
		
		public bool success;
		
		public ExchangeLeaveMessage()
		{
		}
		
		public ExchangeLeaveMessage(sbyte dialogType, bool success)
			 : base(dialogType)
		{
			this.success = success;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteBoolean(success);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			success = reader.ReadBoolean();
		}
	}
}
