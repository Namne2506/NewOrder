using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public Category()
    {
        
    }

    public Category(int categoryId, string categoryName)
    {
        CategoryId = categoryId;
        CategoryName = categoryName;
    }
}
