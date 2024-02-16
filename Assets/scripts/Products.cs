using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Products : MonoBehaviour
{


    private void displayProducts()
    {

        DataSource dataSource = new DataSource();


        GameObject productCardTemplate = this.transform.GetChild(0).gameObject;

        foreach (Product product in dataSource.products)
        {

            // Get the product image from the resources folder, though this can be easily replaced
            // with loading the image from a remote source like a server in practice

            Texture2D img = Resources.Load<Texture2D>(product.getImage());
            GameObject productCard = Instantiate(productCardTemplate, transform);
           // productCard.transform.GetChild(1).g

            // Set thr product image of the product 
            productCard.transform.GetChild(0).GetComponent<RawImage>().texture = img;
            productCard.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = product.getName();
            productCard.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = "KSH "+ product.getPrice().ToString();


            productCard.GetComponent<Button>().onClick.AddListener(delegate () {
                DataStore.Instance.setSelectedProduct(product);
                SceneManager.LoadScene("ProductDetails");
            });
        }
       
        // Discard the product template
        Destroy(productCardTemplate.gameObject);
    }

    // Start is called before the first frame update

    void Start()
    {
        // Instantiate the Datasource which contains all the products


        this.displayProducts();
        
       // Destroy(productCard);
        
    }

   
}
