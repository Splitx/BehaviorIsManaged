// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'AtlasPointsInformations.xml' the '27/06/2012 15:55:15'
using System;
using BiM.Core.IO;
using System.Collections.Generic;
using System.Linq;

namespace BiM.Protocol.Types
{
	public class AtlasPointsInformations
	{
		public const uint Id = 175;
		public virtual short TypeId
		{
			get
			{
				return 175;
			}
		}
		
		public sbyte type;
		public IEnumerable<Types.MapCoordinatesExtended> coords;
		
		public AtlasPointsInformations()
		{
		}
		
		public AtlasPointsInformations(sbyte type, IEnumerable<Types.MapCoordinatesExtended> coords)
		{
			this.type = type;
			this.coords = coords;
		}
		
		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(type);
			writer.WriteUShort((ushort)coords.Count());
			foreach (var entry in coords)
			{
				entry.Serialize(writer);
			}
		}
		
		public virtual void Deserialize(IDataReader reader)
		{
			type = reader.ReadSByte();
			if ( type < 0 )
			{
				throw new Exception("Forbidden value on type = " + type + ", it doesn't respect the following condition : type < 0");
			}
			int limit = reader.ReadUShort();
			coords = new Types.MapCoordinatesExtended[limit];
			for (int i = 0; i < limit; i++)
			{
				(coords as MapCoordinatesExtended[])[i] = new Types.MapCoordinatesExtended();
				(coords as Types.MapCoordinatesExtended[])[i].Deserialize(reader);
			}
		}
	}
}
