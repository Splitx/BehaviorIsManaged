// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameRolePlayHumanoidInformations.xml' the '27/06/2012 15:55:15'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Types
{
	public class GameRolePlayHumanoidInformations : GameRolePlayNamedActorInformations
	{
		public const uint Id = 159;
		public override short TypeId
		{
			get
			{
				return 159;
			}
		}
		
		public Types.HumanInformations humanoidInfo;
		
		public GameRolePlayHumanoidInformations()
		{
		}
		
		public GameRolePlayHumanoidInformations(int contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, string name, Types.HumanInformations humanoidInfo)
			 : base(contextualId, look, disposition, name)
		{
			this.humanoidInfo = humanoidInfo;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort(humanoidInfo.TypeId);
			humanoidInfo.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			humanoidInfo = ProtocolTypeManager.GetInstance<Types.HumanInformations>(reader.ReadShort());
			humanoidInfo.Deserialize(reader);
		}
	}
}
