using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Product
{
    private string name;
    private string description;
    private float price;
    private string id;
    private string image;
    private string modelFile;

    public string getName(){
        return this.name;

    }
    public string getDescription(){
        return this.description;
    }
    public float getPrice(){
        return this.price;
    }
    public string getId(){
        return this.id;
    }
    public string getImage(){
        return this.image;  
    }
    public string getModelFile()
    {
        return this.modelFile;
    }


    public Product(string id, string name, float price, string description, string image, string modelFile){
        this.name = name;
        this.description = description;
        this.id = id;
        this.price = price;
        this.image = image;
        this.modelFile = modelFile;
    }
}
