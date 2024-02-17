# 🚀 ✨ AR STORE DEMO PROJECT ✨ 🚀

## HOW IT WORKS ⚙️ 

This project illustrates the use of markerless Augmented Reality in an e-commerce style application.
Simply select a product, view it's details and click on AR view to check out it's 3D model and impose it on
a surface using ground plane detection.

### DEMO 🚀
![AR store gif](/gitfiles/arstore.gif)

## USER INTERFACE
 
The app consists of three screens:
### 1.	Products Screen 
Initial screen displaying a scrollable list of products.
<p align="center">
  <img src="/gitfiles/productsscreen.png" alt="Screen displaying a scrollable list of products."/>
</p>
### 2. Products Details Screen 
A screen to display the details when a product is selected.
<p align="center">
  <img src="/gitfiles/productdetailsscreen.png" alt="Screen to display the details when a product is selected."/>
</p>
### 3. AR View Screen 
A screen to display the Augmented model of the product.
<p align="center">
  <img src="/gitfiles/arviewscreen.png" alt="Screen to display the Augmented model of the product."/>
</p>

## TESTING 
The project requires Vuforia SDK as a dependancy to perform Ground Plane detetion.
I developed and tested it on Unity version 2022.3.19f1.

### Unity Editor
On the editor ground plane detection does not work, so Vuforia provides a document with a ground plane marker as a substitute.
Simply printout the groundplane marker or open the pdf on your phone and align it towards the Unity editor camera
and it will work just as normal groundplane detection does.
[Download ground plane detection marker for Unity Editor](https://github.com/tostegroo/Vuforia7Template/blob/master/Assets/Editor/Vuforia/ForPrint/Emulator/Emulator%20Ground%20Plane.pdf)
### Android
Vuforia SDK currently only supports Android versions 8.0 +.
AR Core support is also required to be able top perform ground plane detection.
#### **Download Demo APK**
armeabi-v7a architecture should work on most android devices as per the previously stated requirements.
[Download Android APK](https://drive.google.com/file/d/1XIBA4brDT4Zi_ax6k7GUzoiZn0gz9n5a/view?usp=sharing)
#### **Download Demo APK**
arm64-v8a	 architecture download.
[Download Android APK](https://drive.google.com/file/d/1_jiLIUCZvgXrhG09dGvqBi1nMmEcWHcn/view?usp=sharing)
### IOS
Minimum version supported is IOS 15+

## INSTALLATION
Ensure you have Unity Installed.
Download or clone the repo onto your machine, then install the following dependancies for the project to run.
### Dependancies
#### 1. Vuforia SDK
You need to install the Vuforia SDK Unity package. The download link and instructions 
are here -> [Click here to download Vuforia SDK Unity package] (https://developer.vuforia.com/library/getting-started/getting-started-vuforia-engine-unity#adding-vuforia%C2%A0engine-to-a-unity-project)
#### 2. gltFast package
The gltFast package is required in order to load .gltf 3D models from the internet.
Select version 6.2 from the dropwdown on the top left.
[Click here for gltFast installation instructions](https://developer.vuforia.com/library/getting-started/getting-started-vuforia-engine-unity#adding-vuforia%C2%A0engine-to-a-unity-project)
##### Note if gltFast installation keeps failing try running Unity as Administrator 

## 3D Model Sources
I sourced the 3D models from Khronos group repo, no need to re-download them they are fetched automatically
during runtime. 
https://github.com/KhronosGroup/glTF-Sample-Assets/tree/main/Models/

## APPLICATION ARCHITECTURE PATTERN
The app utilizes the **Model View Controller (MVC)** design pattern.
### 1.Views
The View is comprised of the User Interface, and UI components.\
In Unity the 3 screens displayed Products, Product Details and AR View represent the View layer of our design.
### 2. Model 
The model layer is responsible for business logic and data classes.\
In our application we have the following classes forming our model.\
1.) [DataSource.cs](/Assets/scripts/DataSource.cs) - This class contains the business logic for fetching all the data about products such as images, name, id\
2.) [Product.cs](/Assets/scripts/Product.cs) - This class makes up the structure of a Product. It contains all the data
about a particular product such as modelFile, name, imageUrl.
### 3. Controller
The controller layer enables the View layer to Comunicate with the Model layer.\
The flowing classes make this possible:\
1.) [Products.cs](/Assets/scripts/Products.cs) - This controller displays product data on the products page and also listens to events comping from the products page.\
2.) [ProductDetails.cs](/Assets/scripts/ProductDetails.cs) - This class controlls the data displayed on the product details page.\
3.) [ModelLoader.cs](/Assets/scripts/ModelLoader.cs) - This class loads the 3D model for AR display on launch of the
ARView page.

### **Singleton Pattern**
The [DataStore.cs](/Assets/scripts/DataStore.cs) - This class is instanciated onl once throughout the lifetime of the
applicaton and is accessible to all screens. It contains data about the currenty selected product by the user, and also the list of all products loaded to save on operation costs, of making multiple repeated requests to fetch data.