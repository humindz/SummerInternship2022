namespace HumindZ.SummerInternship2022.Business
{
    using System;
    using System.Collections.Generic;

    public class Product
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCategoryType { get; set; }
        public string ProductShortDescription { get; set; }
        public string ProductLongDescription { get; set; }
        public string ProductVersion { get; set; }
        public DateTime ProductVersionDate { get; set; }
        public string ProductVersionNotes { get; set; }
        public IList<ProductDocumentExamples> ProductDocumentExamples { get; set; }
        public IList<ProductDocumentDocumentationLinks> ProductDocumentDocumentationLinks { get; set; }
    }
}
