using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyOrderTest
{
    public interface IOrderService
    {
        List<int> CalculateTotal<T>(List<T> values, int countSize, string fieldName);
    }

    public class OrderService:IOrderService
    {

        public List<int> CalculateTotal<T>(List<T> values, int countSize, string fieldName)
        {
            List<int> resultList = new List<int>();
            var value = 0;
            var total = 0;
            var counter = 0;

            foreach (object obj in values) {
                value = (int) obj.GetType().GetProperty(fieldName).GetValue(obj, null);
                counter++;
                total += value;

                if (counter == countSize)
                {
                    resultList.Add(total);
                    counter = 0;
                    total = 0;
                }
            }

            if (counter > 0 && counter != countSize) {
                resultList.Add(total);    
            }
            
            
            return resultList;
        }
    }

    public class Order
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public int Revenue { get; set; }
        public int SellPrice { get; set; }
     
    }
}
