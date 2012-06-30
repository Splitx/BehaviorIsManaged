// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'JobLevelUpMessage.xml' the '27/06/2012 15:55:03'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class JobLevelUpMessage : NetworkMessage
	{
		public const uint Id = 5656;
		public override uint MessageId
		{
			get
			{
				return 5656;
			}
		}
		
		public sbyte newLevel;
		public Types.JobDescription jobsDescription;
		
		public JobLevelUpMessage()
		{
		}
		
		public JobLevelUpMessage(sbyte newLevel, Types.JobDescription jobsDescription)
		{
			this.newLevel = newLevel;
			this.jobsDescription = jobsDescription;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(newLevel);
			jobsDescription.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			newLevel = reader.ReadSByte();
			if ( newLevel < 0 )
			{
				throw new Exception("Forbidden value on newLevel = " + newLevel + ", it doesn't respect the following condition : newLevel < 0");
			}
			jobsDescription = new Types.JobDescription();
			jobsDescription.Deserialize(reader);
		}
	}
}
