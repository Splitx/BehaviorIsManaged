// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'DungeonPartyFinderRoomContentUpdateMessage.xml' the '27/06/2012 15:55:04'
using System;
using BiM.Core.IO;
using System.Collections.Generic;
using System.Linq;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class DungeonPartyFinderRoomContentUpdateMessage : NetworkMessage
	{
		public const uint Id = 6250;
		public override uint MessageId
		{
			get
			{
				return 6250;
			}
		}
		
		public short dungeonId;
		public Types.DungeonPartyFinderPlayer[] addedPlayers;
		public int[] removedPlayersIds;
		
		public DungeonPartyFinderRoomContentUpdateMessage()
		{
		}
		
		public DungeonPartyFinderRoomContentUpdateMessage(short dungeonId, Types.DungeonPartyFinderPlayer[] addedPlayers, int[] removedPlayersIds)
		{
			this.dungeonId = dungeonId;
			this.addedPlayers = addedPlayers;
			this.removedPlayersIds = removedPlayersIds;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort(dungeonId);
			writer.WriteUShort((ushort)addedPlayers.Count());
			foreach (var entry in addedPlayers)
			{
				entry.Serialize(writer);
			}
			writer.WriteUShort((ushort)removedPlayersIds.Count());
			foreach (var entry in removedPlayersIds)
			{
				writer.WriteInt(entry);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			dungeonId = reader.ReadShort();
			if ( dungeonId < 0 )
			{
				throw new Exception("Forbidden value on dungeonId = " + dungeonId + ", it doesn't respect the following condition : dungeonId < 0");
			}
			int limit = reader.ReadUShort();
			addedPlayers = new Types.DungeonPartyFinderPlayer[limit];
			for (int i = 0; i < limit; i++)
			{
				(addedPlayers as Types.DungeonPartyFinderPlayer[])[i] = new Types.DungeonPartyFinderPlayer();
				(addedPlayers as Types.DungeonPartyFinderPlayer[])[i].Deserialize(reader);
			}
			limit = reader.ReadUShort();
			removedPlayersIds = new int[limit];
			for (int i = 0; i < limit; i++)
			{
				(removedPlayersIds as int[])[i] = reader.ReadInt();
			}
		}
	}
}
