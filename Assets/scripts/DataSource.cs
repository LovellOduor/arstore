using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DataSource

{

    // Load the products from the api and store them from json to c# dictionary
    public Dictionary<string,object>[] getProducts()
    {
        /*Ideally get products can be modified to get product data from the server in JSON
         format and then transform the data to a dictionary array of product data.
        However since we are deploying locally I will hard code the product data into a
        dictionary array */
        Dictionary<string, object>[] productsData = {

            new Dictionary<string, object>{
                {"id","1"},
                {"name","Sheen Chair"},
                {"price","7500"},
                {"description","Comfortable wooden Sheen Chair."},
                {"image","Images/sheenchair"},
                {"modelFile","https://raw.githubusercontent.com/KhronosGroup/glTF-Sample-Assets/main/Models/SheenChair/glTF-Binary/SheenChair.glb"},
            },

            new Dictionary<string, object>{
                {"id","2"},
                {"name","Rubber Duck"},
                {"price","500"},
                {"description","Nice tiny yellow rubber duck."},
                {"image","Images/rubberduck"},
                {"modelFile","https://raw.githubusercontent.com/KhronosGroup/glTF-Sample-Models/master/2.0/Duck/glTF/Duck.gltf"},
            },

             new Dictionary<string, object>{
                {"id","3"},
                {"name","Water Bottle"},
                {"price","1500"},
                {"description","An adjustable table lamp suitable for a study desk."},
                {"image","Images/waterbottle"},
                {"modelFile","https://raw.githubusercontent.com/KhronosGroup/glTF-Sample-Assets/main/Models/WaterBottle/glTF-Binary/WaterBottle.glb"},
            }

        };
        return productsData;

    }
    
}
