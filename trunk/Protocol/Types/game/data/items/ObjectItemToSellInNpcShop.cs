// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ObjectItemToSellInNpcShop.xml' the '27/06/2012 15:55:16'
using System;
using BiM.Core.IO;
using System.Collections.Generic;

namespace BiM.Protocol.Types
{
	public class ObjectItemToSellInNpcShop : ObjectItemMinimalInformation
	{
		public const uint Id = 352;
		public override short TypeId
		{
			get
			{
				return 352;
			}
		}
		
		public int objectPrice;
		public string buyCriterion;
		
		public ObjectItemToSellInNpcShop()
		{
		}
		
		public ObjectItemToSellInNpcShop(short objectGID, short powerRate, bool overMax, Types.ObjectEffect[] effects, int objectPrice, string buyCriterion)
			 : base(objectGID, powerRate, overMax, effects)
		{
			this.objectPrice = objectPrice;
			this.buyCriterion = buyCriterion;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(objectPrice);
			writer.WriteUTF(buyCriterion);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			objectPrice = reader.ReadInt();
			if ( objectPrice < 0 )
			{
				throw new Exception("Forbidden value on objectPrice = " + objectPrice + ", it doesn't respect the following condition : objectPrice < 0");
			}
			buyCriterion = reader.ReadUTF();
		}
	}
}
