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
### Dependancies

## SYSTEM ARCHITECTURE 

