using System;
namespace DesignPattern
{
	public class ProductClass
	{
			public string name { get; set; }
			public string price { get; set; }
		    public IList<ProductCVarient> productCVarients { get; set; }
	}

	public class ProductCVarient
	{
		public int varientId { get; set; }
		public string varientName { get; set; }
    }
}

