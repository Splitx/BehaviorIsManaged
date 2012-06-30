// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ShortcutObjectPreset.xml' the '27/06/2012 15:55:17'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Types
{
	public class ShortcutObjectPreset : ShortcutObject
	{
		public const uint Id = 370;
		public override short TypeId
		{
			get
			{
				return 370;
			}
		}
		
		public sbyte presetId;
		
		public ShortcutObjectPreset()
		{
		}
		
		public ShortcutObjectPreset(int slot, sbyte presetId)
			 : base(slot)
		{
			this.presetId = presetId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(presetId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			presetId = reader.ReadSByte();
			if ( presetId < 0 )
			{
				throw new Exception("Forbidden value on presetId = " + presetId + ", it doesn't respect the following condition : presetId < 0");
			}
		}
	}
}
