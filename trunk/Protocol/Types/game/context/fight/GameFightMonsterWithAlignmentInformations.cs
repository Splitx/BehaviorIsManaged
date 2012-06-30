// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameFightMonsterWithAlignmentInformations.xml' the '27/06/2012 15:55:15'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Types
{
	public class GameFightMonsterWithAlignmentInformations : GameFightMonsterInformations
	{
		public const uint Id = 203;
		public override short TypeId
		{
			get
			{
				return 203;
			}
		}
		
		public Types.ActorAlignmentInformations alignmentInfos;
		
		public GameFightMonsterWithAlignmentInformations()
		{
		}
		
		public GameFightMonsterWithAlignmentInformations(int contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, sbyte teamId, bool alive, Types.GameFightMinimalStats stats, short creatureGenericId, sbyte creatureGrade, Types.ActorAlignmentInformations alignmentInfos)
			 : base(contextualId, look, disposition, teamId, alive, stats, creatureGenericId, creatureGrade)
		{
			this.alignmentInfos = alignmentInfos;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			alignmentInfos.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			alignmentInfos = new Types.ActorAlignmentInformations();
			alignmentInfos.Deserialize(reader);
		}
	}
}
