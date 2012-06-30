// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'HousePropertiesMessage.xml' the '27/06/2012 15:55:03'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class HousePropertiesMessage : NetworkMessage
	{
		public const uint Id = 5734;
		public override uint MessageId
		{
			get
			{
				return 5734;
			}
		}
		
		public Types.HouseInformations properties;
		
		public HousePropertiesMessage()
		{
		}
		
		public HousePropertiesMessage(Types.HouseInformations properties)
		{
			this.properties = properties;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort(properties.TypeId);
			properties.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			properties = Types.ProtocolTypeManager.GetInstance<Types.HouseInformations>(reader.ReadShort());
			properties.Deserialize(reader);
		}
	}
}
