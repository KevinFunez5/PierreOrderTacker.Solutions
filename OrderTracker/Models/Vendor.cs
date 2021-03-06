using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public List<Order> Orders { get; set; }
    public int Id { get; }
    private static List<Vendor> _vendorList = new List<Vendor>{};

    public Vendor(string name)
    {
      Name = name;
      Orders = new List<Order>{};
      Id = _vendorList.Count+1;
      _vendorList.Add(this);
    }

    public static List<Vendor> GetAll()
    {
      return _vendorList;
    }

    public static void ClearAll()
    {
      _vendorList.Clear();
    }

    public static Vendor GetById(int id)
    {
      return _vendorList[id-1];
    }

    public void AddOrder(string title, string description, double cost, int month, int day)
    {
      Order newOrder = new(title, description, cost, month, day);
      Orders.Add(newOrder);
    }
  }
}