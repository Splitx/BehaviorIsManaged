// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'CharacterFirstSelectionMessage.xml' the '27/06/2012 15:54:58'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class CharacterFirstSelectionMessage : CharacterSelectionMessage
	{
		public const uint Id = 6084;
		public override uint MessageId
		{
			get
			{
				return 6084;
			}
		}
		
		public bool doTutorial;
		
		public CharacterFirstSelectionMessage()
		{
		}
		
		public CharacterFirstSelectionMessage(int id, bool doTutorial)
			 : base(id)
		{
			this.doTutorial = doTutorial;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteBoolean(doTutorial);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			doTutorial = reader.ReadBoolean();
		}
	}
}
