using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DataSource

{

    public List<Product> products = new List<Product>();

    /* This constructor converts data from the data source to Product data which utilizes the product class
       and stores all the products in the products list.*/

    public DataSource()
    {
       Dictionary<string,object>[] productsData = this.getProducts();
        for (int i =0; i < productsData.Length;i++)
        {
            Dictionary<string, object> product = productsData[i];
            products.Add(new Product(
                id:product["id"] as string,
                name:product["name"] as string, 
                price:float.Parse((string)product["price"]) ,
                description:product["description"] as string, 
                image:product["image"] as string, 
                modelFile:product["modelFile"] as string));
        }
    }

    // Load the products from the api and store them from json to c# dictionary
    public Dictionary<string,object>[] getProducts()
    {
        /*Ideally get products can be modified to get product data from the server in JSON
         format and then transform the data to a dictionary array of product data.
        However since we are deploying locally I will hard code the product data into a
        dictionary array */
        Dictionary<string, object>[] productsData = {

            new Dictionary<string, object>{
                {"id","ajlajk"},
                {"name","Table Lamp"},
                {"price","2500"},
                {"description","An adjustable table lamp suitable for a study desk."},
                {"image","Images/table_lamp"},
                {"modelFile","dads"},
            },

            new Dictionary<string, object>{
                {"id","ajlajdsdk"},
                {"name","Table Lamp 2"},
                {"price","2500"},
                {"description","An adjustable table lamp suitable for a study desk."},
                {"image","Images/table_lamp"},
                {"modelFile","asdsdsa"},
            }

        };
        return productsData;

    }
    
}
