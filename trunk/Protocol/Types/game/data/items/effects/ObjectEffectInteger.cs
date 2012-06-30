// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ObjectEffectInteger.xml' the '27/06/2012 15:55:16'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Types
{
	public class ObjectEffectInteger : ObjectEffect
	{
		public const uint Id = 70;
		public override short TypeId
		{
			get
			{
				return 70;
			}
		}
		
		public short value;
		
		public ObjectEffectInteger()
		{
		}
		
		public ObjectEffectInteger(short actionId, short value)
			 : base(actionId)
		{
			this.value = value;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort(value);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			value = reader.ReadShort();
			if ( value < 0 )
			{
				throw new Exception("Forbidden value on value = " + value + ", it doesn't respect the following condition : value < 0");
			}
		}
	}
}