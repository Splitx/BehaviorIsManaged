// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'FightResultAdditionalData.xml' the '27/06/2012 15:55:15'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Types
{
	public class FightResultAdditionalData
	{
		public const uint Id = 191;
		public virtual short TypeId
		{
			get
			{
				return 191;
			}
		}
		
		
		public virtual void Serialize(IDataWriter writer)
		{
		}
		
		public virtual void Deserialize(IDataReader reader)
		{
		}
	}
}
