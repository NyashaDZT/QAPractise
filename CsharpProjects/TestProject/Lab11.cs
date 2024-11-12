using System.Collections.Generic;

namespace LabEleven
{
    class ShoppingBasket 
    {
        public string productName;
        private int quantity;
        private double price;

        public ShoppingBasket(string productName, int quantity, double price)
        {
            this.productName = productName;
            this.quantity = quantity;
            this.price = price;

        }
    }

    class QAShop()
    {
        private Queue<ShoppingBasket> baskets = new Queue<ShoppingBasket>();

        public void Buy(ShoppingBasket basket)
        {
            baskets.Enqueue(basket);
            Console.WriteLine($"Shopping basket for {basket.productName} queued!");
        } 

        public void ProcessBaskets()
        {
            while (baskets.Count > 0 )
            {
                ShoppingBasket basket = baskets.Dequeue();
                Console.WriteLine($"{basket}");
            }
        }


    }
}