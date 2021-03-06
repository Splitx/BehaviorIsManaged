// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ActorOrientation.xml' the '27/06/2012 15:55:14'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Types
{
	public class ActorOrientation
	{
		public const uint Id = 353;
		public virtual short TypeId
		{
			get
			{
				return 353;
			}
		}
		
		public int id;
		public sbyte direction;
		
		public ActorOrientation()
		{
		}
		
		public ActorOrientation(int id, sbyte direction)
		{
			this.id = id;
			this.direction = direction;
		}
		
		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteInt(id);
			writer.WriteSByte(direction);
		}
		
		public virtual void Deserialize(IDataReader reader)
		{
			id = reader.ReadInt();
			direction = reader.ReadSByte();
			if ( direction < 0 )
			{
				throw new Exception("Forbidden value on direction = " + direction + ", it doesn't respect the following condition : direction < 0");
			}
		}
	}
}
