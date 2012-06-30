// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'DownloadCurrentSpeedMessage.xml' the '27/06/2012 15:55:13'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class DownloadCurrentSpeedMessage : NetworkMessage
	{
		public const uint Id = 1511;
		public override uint MessageId
		{
			get
			{
				return 1511;
			}
		}
		
		public sbyte downloadSpeed;
		
		public DownloadCurrentSpeedMessage()
		{
		}
		
		public DownloadCurrentSpeedMessage(sbyte downloadSpeed)
		{
			this.downloadSpeed = downloadSpeed;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(downloadSpeed);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			downloadSpeed = reader.ReadSByte();
			if ( downloadSpeed < 1 || downloadSpeed > 10 )
			{
				throw new Exception("Forbidden value on downloadSpeed = " + downloadSpeed + ", it doesn't respect the following condition : downloadSpeed < 1 || downloadSpeed > 10");
			}
		}
	}
}
