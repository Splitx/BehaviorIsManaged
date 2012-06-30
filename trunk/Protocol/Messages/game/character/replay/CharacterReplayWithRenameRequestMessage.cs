// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'CharacterReplayWithRenameRequestMessage.xml' the '27/06/2012 15:54:59'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class CharacterReplayWithRenameRequestMessage : CharacterReplayRequestMessage
	{
		public const uint Id = 6122;
		public override uint MessageId
		{
			get
			{
				return 6122;
			}
		}
		
		public string name;
		
		public CharacterReplayWithRenameRequestMessage()
		{
		}
		
		public CharacterReplayWithRenameRequestMessage(int characterId, string name)
			 : base(characterId)
		{
			this.name = name;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(name);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			name = reader.ReadUTF();
		}
	}
}
