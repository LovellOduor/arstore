using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class backNavigation : MonoBehaviour
{
    public GameObject backNavigationButton;

    // Start is called before the first frame update
    void Start()
    {
        backNavigationButton.GetComponent<Button>().onClick.AddListener(delegate () {
            SceneManager.LoadScene("ProductDetails");
        });

    }
}
