using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataStore : MonoBehaviour
{
    public static DataStore Instance;

    private Product selectedProduct;

    public void setSelectedProduct(Product product)
    {
        selectedProduct = product;

    }

    public Product getSelectedProduct() {  return selectedProduct; }


    // Update is called once per frame
    void Awake()
    {
        // start of new code
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);

    }
}
