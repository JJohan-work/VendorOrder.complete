using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    public string Desc { get; set; }
    public int Balance { get; private set;} = 0;
    public int Id { get; private set;}
    public List<Order> Orders { get; set; }

    public Vendor(string name, string desc)
    {
      Name = name;
      Desc = desc;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order>{};
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Vendor Find(int id)
    {
      return _instances[id - 1];
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public void AddOrder(Order newOrder)
    {
      Orders.Add(newOrder);
    }

    public List<Order> GetAllOrders()
    {
      return Orders;
    }

    public Order GetOrder(int id)
    {
      return Orders[id-1];
    }

    public void RemoveOrder(int id, int OrderPlace)
    {
      Orders.RemoveAt(id-1);
      Order.RemoveOrder(OrderPlace);

      for (int i=0; i < Orders.Count; i++)
      {
        Orders[i].Changeid(i+1);
      }
    }

    public void RemoveAllOrders()
    {
      Orders.Clear();
    }
  }
}

//Functions to add
  //Calculate Balance