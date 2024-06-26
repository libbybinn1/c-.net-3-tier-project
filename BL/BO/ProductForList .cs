﻿
namespace BO;

public class ProductForList
    {
    public int ID { get; set; }
    public string? Name { get; set; }
    public double Price { get; set; }
    public Enums.eCategory Category { get; set; }
    public override string ToString() => $@"
    Product ID:{ID},
    name:{Name}, 
    category : {Category}
    Price: {Price}
    ";
}

