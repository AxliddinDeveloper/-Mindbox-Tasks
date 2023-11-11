/*
SELECT 
    P.ProductName, 
    COALESCE(C.CategoryName, 'No Category') AS CategoryName
FROM 
    Products P
LEFT JOIN 
    ProductCategory PC ON P.ProductID = PC.ProductID
LEFT JOIN 
    Categories C ON PC.CategoryID = C.CategoryID;
    
*/