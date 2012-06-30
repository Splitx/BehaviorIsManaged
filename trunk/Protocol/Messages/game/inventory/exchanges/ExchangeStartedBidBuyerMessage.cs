// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeStartedBidBuyerMessage.xml' the '27/06/2012 15:55:10'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class ExchangeStartedBidBuyerMessage : NetworkMessage
	{
		public const uint Id = 5904;
		public override uint MessageId
		{
			get
			{
				return 5904;
			}
		}
		
		public Types.SellerBuyerDescriptor buyerDescriptor;
		
		public ExchangeStartedBidBuyerMessage()
		{
		}
		
		public ExchangeStartedBidBuyerMessage(Types.SellerBuyerDescriptor buyerDescriptor)
		{
			this.buyerDescriptor = buyerDescriptor;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			buyerDescriptor.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			buyerDescriptor = new Types.SellerBuyerDescriptor();
			buyerDescriptor.Deserialize(reader);
		}
	}
}
