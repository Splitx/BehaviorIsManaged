// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GroupMonsterStaticInformationsWithAlternatives.xml' the '27/06/2012 15:55:15'
using System;
using BiM.Core.IO;
using System.Collections.Generic;
using System.Linq;

namespace BiM.Protocol.Types
{
	public class GroupMonsterStaticInformationsWithAlternatives : GroupMonsterStaticInformations
	{
		public const uint Id = 396;
		public override short TypeId
		{
			get
			{
				return 396;
			}
		}
		
		public IEnumerable<Types.AlternativeMonstersInGroupLightInformations> alternatives;
		
		public GroupMonsterStaticInformationsWithAlternatives()
		{
		}
		
		public GroupMonsterStaticInformationsWithAlternatives(Types.MonsterInGroupLightInformations mainCreatureLightInfos, IEnumerable<Types.MonsterInGroupInformations> underlings, IEnumerable<Types.AlternativeMonstersInGroupLightInformations> alternatives)
			 : base(mainCreatureLightInfos, underlings)
		{
			this.alternatives = alternatives;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUShort((ushort)alternatives.Count());
			foreach (var entry in alternatives)
			{
				entry.Serialize(writer);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			int limit = reader.ReadUShort();
			alternatives = new Types.AlternativeMonstersInGroupLightInformations[limit];
			for (int i = 0; i < limit; i++)
			{
				(alternatives as AlternativeMonstersInGroupLightInformations[])[i] = new Types.AlternativeMonstersInGroupLightInformations();
				(alternatives as Types.AlternativeMonstersInGroupLightInformations[])[i].Deserialize(reader);
			}
		}
	}
}
