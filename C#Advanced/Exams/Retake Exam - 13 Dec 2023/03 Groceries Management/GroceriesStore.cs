namespace GroceriesManagement
{
    public class GroceriesStore
    {
        public GroceriesStore(int capacity)
        {
            Capacity = capacity;
            Turnover = 0;
            Stall = new List<Product>();
        }

        public int 	Capacity { get; set; }

        public double Turnover  { get; set; }

        public List<Product> Stall { get; set; }


        public void AddProduct(Product product)
        {
            bool isExist = Stall.Where(x=>x.Name == product.Name).Any();

            if(Stall.Count() < Capacity && !isExist)
            {
                Stall.Add(product);
            }
        }

        public bool RemoveProduct(string name) =>
            Stall.Remove(Stall.FirstOrDefault(p => p.Name == name));

        public string SellProduct(string name, double quantity)
        {
            Product product = Stall.Where(p => p.Name == name).FirstOrDefault();
            double total = 0.00;

            if(product == null)
            {
                return "Product not found";
            }
            Turnover += product.Price * quantity;

            return $"{product.Name} - {Turnover:f2}$";
        }

        public string GetMostExpensive()
        {
            return Stall.OrderByDescending(p => p.Price).FirstOrDefault().ToString();
        }

        public string CashReport()
        {
            return $"Total Turnover: {Turnover:f2}$";
        }

        public string PriceList()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Groceries Price List:");
            
            if(Stall.Any())
            {
                foreach (var p in Stall)
                {
                    sb.AppendLine(p.ToString());
                }
            }
            return sb.ToString().TrimEnd();
        }

    }
}
