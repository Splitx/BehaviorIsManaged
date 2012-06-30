// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ShortcutBarRefreshMessage.xml' the '27/06/2012 15:55:13'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class ShortcutBarRefreshMessage : NetworkMessage
	{
		public const uint Id = 6229;
		public override uint MessageId
		{
			get
			{
				return 6229;
			}
		}
		
		public sbyte barType;
		public Types.Shortcut shortcut;
		
		public ShortcutBarRefreshMessage()
		{
		}
		
		public ShortcutBarRefreshMessage(sbyte barType, Types.Shortcut shortcut)
		{
			this.barType = barType;
			this.shortcut = shortcut;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(barType);
			writer.WriteShort(shortcut.TypeId);
			shortcut.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			barType = reader.ReadSByte();
			if ( barType < 0 )
			{
				throw new Exception("Forbidden value on barType = " + barType + ", it doesn't respect the following condition : barType < 0");
			}
			shortcut = Types.ProtocolTypeManager.GetInstance<Types.Shortcut>(reader.ReadShort());
			shortcut.Deserialize(reader);
		}
	}
}
