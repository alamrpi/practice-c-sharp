public class Product
{
    //fields

    //accessModifier modifier type FieldName;

    //private, protected, private protected, internal, protected internal, public

    public int productID;
    public string productName;

    public int quantityInStock;

    public static int counter;
    
    public Product(int quantityInStock) 
    { 
        this.quantityInStock = quantityInStock;
    }

    public Product()
    {

    }

}

//Child class at same assembly
public class DomesticProduct : Product
{
    //public void Method1()
    //{
    //    productID = 1;
    //    //productName = "abc"; //accessible
    //    //cost = 1000; //accessible
    //    //quantityInStock = 10; //accessible
    //}
}

//Other class at same assembly
public class OtherClass
{
    //public void Method1()
    //{
    //    Product product = new Product();

    //    product.productID =

    //    product.productID = 1; //not valid
    //    product.productName = "abc"; //not valid
    //    product.cost = 2000; //accessible
    //    product.quantityInStock = 10; //accessible
    //}
}
