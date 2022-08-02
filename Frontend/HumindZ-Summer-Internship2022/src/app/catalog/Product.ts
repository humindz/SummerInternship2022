export interface IProduct {
    ProductId: string;
    ProductName: string;
    ProductCategoryType: string;
    ProductShortDescription: string;
    ProductLongDescription: string;
    ProductVersion: string;
    ProductVersionDate: string;  //                 //dateTime helyett
    ProductVersionNotes: string;

    //ide kell ProductDocumentExamples es ProductDocumentDocumentationLinks
  }
  