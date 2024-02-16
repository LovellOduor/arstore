using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ProductDetails : MonoBehaviour
{

    public GameObject productImage;
    public GameObject title;
    public GameObject productName;
    public GameObject productPrice;
    public GameObject productDescription;
    public GameObject ARViewButton;
    public GameObject backNavigationButton;
    
    // Start is called before the first frame update
    void Start()
    {
     Product product = DataStore.Instance.getSelectedProduct();
     if (product == null) return;
     title.GetComponent<TextMeshProUGUI>().text = product.getName();
     productName.GetComponent<TextMeshProUGUI>().text = product.getName();
     productPrice.GetComponent<TextMeshProUGUI>().text = "KSH " + product.getPrice().ToString();
     productDescription.GetComponent<TextMeshProUGUI>().text = product.getDescription();
     Texture2D img = Resources.Load<Texture2D>(product.getImage());
     productImage.GetComponent<RawImage>().texture = img;

    }


}
