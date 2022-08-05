export interface IProduct {
    productId: string;
    productName: string;
    productCategoryType: string;
    productShortDescription: string;
    productLongDescription: string;
    productVersion: string;
    productVersionDate: string;  //                 //dateTime helyett
    productVersionNotes: string;
    productPrice: string;

    //ide kell ProductDocumentExamples es ProductDocumentDocumentationLinks
  }
  