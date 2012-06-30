// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'AbstractPartyEventMessage.xml' the '27/06/2012 15:55:04'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class AbstractPartyEventMessage : AbstractPartyMessage
	{
		public const uint Id = 6273;
		public override uint MessageId
		{
			get
			{
				return 6273;
			}
		}
		
		
		public AbstractPartyEventMessage()
		{
		}
		
		public AbstractPartyEventMessage(int partyId)
			 : base(partyId)
		{
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
		}
	}
}
