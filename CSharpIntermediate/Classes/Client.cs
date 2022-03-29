using System.Collections.Generic;

namespace CSharpIntermediate.Classes
{
    public class Client
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Client()
        {
            Orders = new List<Order>();
        }
        public Client(int id):this() 
        {
            this.Id = id;
        }

        public Client(int id, string name):this(id)
        {
            
            this.Name = name;
        }
    }
}
