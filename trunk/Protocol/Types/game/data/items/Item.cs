// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'Item.xml' the '27/06/2012 15:55:16'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Types
{
	public class Item
	{
		public const uint Id = 7;
		public virtual short TypeId
		{
			get
			{
				return 7;
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
