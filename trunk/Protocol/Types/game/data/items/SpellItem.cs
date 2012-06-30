// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'SpellItem.xml' the '27/06/2012 15:55:16'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Types
{
	public class SpellItem : Item
	{
		public const uint Id = 49;
		public override short TypeId
		{
			get
			{
				return 49;
			}
		}
		
		public byte position;
		public int spellId;
		public sbyte spellLevel;
		
		public SpellItem()
		{
		}
		
		public SpellItem(byte position, int spellId, sbyte spellLevel)
		{
			this.position = position;
			this.spellId = spellId;
			this.spellLevel = spellLevel;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(position);
			writer.WriteInt(spellId);
			writer.WriteSByte(spellLevel);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			position = reader.ReadByte();
			if ( position < 63 || position > 255 )
			{
				throw new Exception("Forbidden value on position = " + position + ", it doesn't respect the following condition : position < 63 || position > 255");
			}
			spellId = reader.ReadInt();
			spellLevel = reader.ReadSByte();
			if ( spellLevel < 1 || spellLevel > 6 )
			{
				throw new Exception("Forbidden value on spellLevel = " + spellLevel + ", it doesn't respect the following condition : spellLevel < 1 || spellLevel > 6");
			}
		}
	}
}
