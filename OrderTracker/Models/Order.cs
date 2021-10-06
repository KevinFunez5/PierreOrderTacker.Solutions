using System.Collections.Generic;
using System;

namespace OrderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set;}
    public double Cost { get; set; }
    public DateTime DateOrdered { get; set; }

    public Order(string title, string description, double cost)
    {
      Title = title;
      Description = description;
      Cost = cost;
      DateOrdered = DateTime.Now;
    }
  }
}