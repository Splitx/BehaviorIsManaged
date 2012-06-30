// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ShortcutEmote.xml' the '27/06/2012 15:55:17'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Types
{
	public class ShortcutEmote : Shortcut
	{
		public const uint Id = 389;
		public override short TypeId
		{
			get
			{
				return 389;
			}
		}
		
		public sbyte emoteId;
		
		public ShortcutEmote()
		{
		}
		
		public ShortcutEmote(int slot, sbyte emoteId)
			 : base(slot)
		{
			this.emoteId = emoteId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(emoteId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			emoteId = reader.ReadSByte();
			if ( emoteId < 0 )
			{
				throw new Exception("Forbidden value on emoteId = " + emoteId + ", it doesn't respect the following condition : emoteId < 0");
			}
		}
	}
}