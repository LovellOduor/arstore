using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GLTFast;
using UnityEditor;
using System.IO;
using System.Collections.Specialized;
using System.Reflection;

public class ModelLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Product selectedProduct = DataStore.Instance.getSelectedProduct();
        if (selectedProduct != null)
        {
            var gltf = gameObject.AddComponent<GLTFast.GltfAsset>();
            gltf.Url = selectedProduct.getModelFile();
        }
       
    }


}
