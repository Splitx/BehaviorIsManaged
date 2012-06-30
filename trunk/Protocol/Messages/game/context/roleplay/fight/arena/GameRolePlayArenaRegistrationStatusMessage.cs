// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameRolePlayArenaRegistrationStatusMessage.xml' the '27/06/2012 15:55:02'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class GameRolePlayArenaRegistrationStatusMessage : NetworkMessage
	{
		public const uint Id = 6284;
		public override uint MessageId
		{
			get
			{
				return 6284;
			}
		}
		
		public bool registered;
		public sbyte step;
		public int battleMode;
		
		public GameRolePlayArenaRegistrationStatusMessage()
		{
		}
		
		public GameRolePlayArenaRegistrationStatusMessage(bool registered, sbyte step, int battleMode)
		{
			this.registered = registered;
			this.step = step;
			this.battleMode = battleMode;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(registered);
			writer.WriteSByte(step);
			writer.WriteInt(battleMode);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			registered = reader.ReadBoolean();
			step = reader.ReadSByte();
			if ( step < 0 )
			{
				throw new Exception("Forbidden value on step = " + step + ", it doesn't respect the following condition : step < 0");
			}
			battleMode = reader.ReadInt();
			if ( battleMode < 0 )
			{
				throw new Exception("Forbidden value on battleMode = " + battleMode + ", it doesn't respect the following condition : battleMode < 0");
			}
		}
	}
}
