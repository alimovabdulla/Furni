namespace Furni.Entities
{
	public class Product:BaseEntity
	{
        public string Name { get; set; }
        public string Description { get; set; }
        public string  StockCount  { get; set; }
        public string CostPrice { get; set; }
        public double SalePrice { get; set; }
        public string ImgUrl { get; set; }  
    }
}
