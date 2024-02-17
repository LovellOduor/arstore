using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataStore : MonoBehaviour
{
    public static DataStore Instance;

    // Store products loaded from the DataSource

    public List<Product> products = new List<Product>();

    // Network layer which will request product data 

    public DataSource dataSource = new DataSource();

    // The product clicked by the user to be viewed

    private Product selectedProduct;


    public void setSelectedProduct(Product product)
    {
        selectedProduct = product;

    }

    public Product getSelectedProduct() {  return selectedProduct; }


    // Update is called once per frame
    void Awake()
    {
        // If the Datastore was already created else where destroy the new copy

        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        // Load the products 

        Dictionary<string, object>[] productsData = dataSource.getProducts();
        for (int i = 0; i < productsData.Length; i++)
        {
            Dictionary<string, object> product = productsData[i];
            products.Add(new Product(
                id: product["id"] as string,
                name: product["name"] as string,
                price: float.Parse((string)product["price"]),
                description: product["description"] as string,
                image: product["image"] as string,
                modelFile: product["modelFile"] as string));
        }

        // Create a reference to this datastore

        Instance = this;
        DontDestroyOnLoad(gameObject);

    }
}
