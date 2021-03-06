# SunHacks-AR-Tutorial
###### *Using Unity 2018.2 and ARFoundation 1.0*

This is a Unity tutorial on the forms of input (Gaze, Tap, Movement) available in mobile-device Augmented Reality. This tutorial uses ARFoundation (built on top of ARKit & ARCore) as the framework for **cross platform AR.**

## Please install the following before importing/beginning:
* [Unity 2018.x](https://unity3d.com/get-unity/download/archive)
* iOS [Build Support Tools](https://unity3d.com/learn/tutorials/topics/mobile-touch/building-your-unity-game-ios-device-testing)
* Android [Build Support Tools](https://unity3d.com/learn/tutorials/topics/mobile-touch/building-your-unity-game-android-device-testing)

##### The goal is to replicate this scene from Fast and Furious 7:

![Fast](assets/fast.gif)

##### The intent is to create a plane that is controlled by gaze movement & physical movement. Tapping launches car's out of the plane, holding causes the plane to rotate.

![Airplane](assets/planeAR.gif)

### _Pretty close wouldn't you say?_ :grinning:
---

## Once all tools are installed, please do the following:

* ### Switch Build Platform (**File>Build Settings**) to iOS/Android.
![SwitchBuild](https://i.imgur.com/tX7JCohm.png)
* ### Import package included in this repo (**Assets>Import Package>Custom Package, Select Package from Repo**)
![ImportPackage](https://i.imgur.com/M0B52zym.png)
---
* ### Import AR Packages using Package Manager in Unity:
**Window>Package Manager**
Install ARFoundation, ARCore XR Plugin, and ARKit XR Plugin.
![PackageManager](https://i.imgur.com/7yPZN8gl.gif)

* ### Enable Unsafe Code (using frameworks in pre-release):
![Unsafe](https://i.imgur.com/2sdAXHRl.png)

## Scripts:
* ### ARUserInputManager
_Responsible for determining user gaze, and checking for a touch-hold gesture._
* ### DropCar
_Responsible for instantiating a car prefab and launching it from location of AirPlane/User Gaze. Additionally instantiates a Explosion [Particle System](https://docs.unity3d.com/Manual/ParticleSystems.html)_

_Explosion particle system is downloaded from Unity [Standard Assets](https://assetstore.unity.com/packages/essentials/asset-packs/standard-assets-32351)._

## 3D Models for Tutorial downloaded via Google Poly. Models were created by Google:
* [Convertible Car](https://poly.google.com/view/dggOiBLYyuR)
* [Airplane](https://poly.google.com/view/8VysVKMXN2J)

## References:
* [ARFoundation](https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@1.0/manual/index.html)
* [ARFoundation Samples](https://github.com/Unity-Technologies/arfoundation-samples)
* [Unity API](https://docs.unity3d.com/ScriptReference/MonoBehaviour.html)

### Author:
* [github/TheWiselyBearded](https://github.com/TheWiselyBearded)
* [twitter/lirezaBahremand](https://twitter.com/lirezabahremand)

### License

Copyright © 2018, [Alireza Bahremand](https://github.com/TheWiselyBearded).
Released under the [MIT license](LICENSE).
