// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'SpellUpgradeFailureMessage.xml' the '27/06/2012 15:55:06'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class SpellUpgradeFailureMessage : NetworkMessage
	{
		public const uint Id = 1202;
		public override uint MessageId
		{
			get
			{
				return 1202;
			}
		}
		
		
		public override void Serialize(IDataWriter writer)
		{
		}
		
		public override void Deserialize(IDataReader reader)
		{
		}
	}
}
