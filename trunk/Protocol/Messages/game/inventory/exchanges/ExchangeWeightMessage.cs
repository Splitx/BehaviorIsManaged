// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeWeightMessage.xml' the '27/06/2012 15:55:11'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class ExchangeWeightMessage : NetworkMessage
	{
		public const uint Id = 5793;
		public override uint MessageId
		{
			get
			{
				return 5793;
			}
		}
		
		public int currentWeight;
		public int maxWeight;
		
		public ExchangeWeightMessage()
		{
		}
		
		public ExchangeWeightMessage(int currentWeight, int maxWeight)
		{
			this.currentWeight = currentWeight;
			this.maxWeight = maxWeight;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(currentWeight);
			writer.WriteInt(maxWeight);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			currentWeight = reader.ReadInt();
			if ( currentWeight < 0 )
			{
				throw new Exception("Forbidden value on currentWeight = " + currentWeight + ", it doesn't respect the following condition : currentWeight < 0");
			}
			maxWeight = reader.ReadInt();
			if ( maxWeight < 0 )
			{
				throw new Exception("Forbidden value on maxWeight = " + maxWeight + ", it doesn't respect the following condition : maxWeight < 0");
			}
		}
	}
}
