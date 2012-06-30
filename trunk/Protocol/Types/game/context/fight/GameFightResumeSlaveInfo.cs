// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameFightResumeSlaveInfo.xml' the '27/06/2012 15:55:15'
using System;
using BiM.Core.IO;
using System.Collections.Generic;
using System.Linq;

namespace BiM.Protocol.Types
{
	public class GameFightResumeSlaveInfo
	{
		public const uint Id = 364;
		public virtual short TypeId
		{
			get
			{
				return 364;
			}
		}
		
		public int slaveId;
		public IEnumerable<Types.GameFightSpellCooldown> spellCooldowns;
		public sbyte summonCount;
		public sbyte bombCount;
		
		public GameFightResumeSlaveInfo()
		{
		}
		
		public GameFightResumeSlaveInfo(int slaveId, IEnumerable<Types.GameFightSpellCooldown> spellCooldowns, sbyte summonCount, sbyte bombCount)
		{
			this.slaveId = slaveId;
			this.spellCooldowns = spellCooldowns;
			this.summonCount = summonCount;
			this.bombCount = bombCount;
		}
		
		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteInt(slaveId);
			writer.WriteUShort((ushort)spellCooldowns.Count());
			foreach (var entry in spellCooldowns)
			{
				entry.Serialize(writer);
			}
			writer.WriteSByte(summonCount);
			writer.WriteSByte(bombCount);
		}
		
		public virtual void Deserialize(IDataReader reader)
		{
			slaveId = reader.ReadInt();
			int limit = reader.ReadUShort();
			spellCooldowns = new Types.GameFightSpellCooldown[limit];
			for (int i = 0; i < limit; i++)
			{
				(spellCooldowns as GameFightSpellCooldown[])[i] = new Types.GameFightSpellCooldown();
				(spellCooldowns as Types.GameFightSpellCooldown[])[i].Deserialize(reader);
			}
			summonCount = reader.ReadSByte();
			if ( summonCount < 0 )
			{
				throw new Exception("Forbidden value on summonCount = " + summonCount + ", it doesn't respect the following condition : summonCount < 0");
			}
			bombCount = reader.ReadSByte();
			if ( bombCount < 0 )
			{
				throw new Exception("Forbidden value on bombCount = " + bombCount + ", it doesn't respect the following condition : bombCount < 0");
			}
		}
	}
}
