using System;

namespace HumindZ.SummerInternship2022.Services.Product
{
    public class ProductDto
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCategoryType { get; set; }
        public string ProductShortDescription { get; set; }
        public string ProductLongDescription { get; set; }
        public string ProductVersion { get; set; }
        public DateTime ProductVersionDate { get; set; }
        public string ProductVersionNotes { get; set; }
        public string ProductPrice { get; set; }
    }
}
