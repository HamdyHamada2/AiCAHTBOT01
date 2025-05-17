//namespace AIChatBot.Model
//{
//  public class Product
//  {
//    public int ProductID { get; set; }
//  public string ProductName { get; set; }
//public string Category { get; set; }
//public string Description { get; set; }
//public string Usage { get; set; }
//public string Installation { get; set; }
// }
//}


// ========== Models/Product.cs ==========
namespace ElectronicProductsAPI.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string? Name { get; set; }  // يسمح بأن تكون فارغة (null)
        public string? Description { get; set; }  // يسمح بأن تكون فارغة (null)
        public string? Usage { get; set; }  // يسمح بأن تكون فارغة (null)
        public string? InstallationInstructions { get; set; }  // يسمح بأن تكون فارغة (null)
    }
}

