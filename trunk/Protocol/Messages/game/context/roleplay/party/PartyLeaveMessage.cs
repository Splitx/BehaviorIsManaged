// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'PartyLeaveMessage.xml' the '27/06/2012 15:55:05'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class PartyLeaveMessage : AbstractPartyMessage
	{
		public const uint Id = 5594;
		public override uint MessageId
		{
			get
			{
				return 5594;
			}
		}
		
		
		public PartyLeaveMessage()
		{
		}
		
		public PartyLeaveMessage(int partyId)
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
