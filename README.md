# STEVE
Steve.
DOWNLOAD INSTRUCTIONS
clone into a local repository on your computer. You will need to download your own copy of the GoogleVR SDK,
available here: https://github.com/googlevr/gvr-unity-sdk
clone the googleVR sdk into some other folder. Open the STEVE project in Unity, and you will receive a ton of errors.
This is because the googleVR SDK has not yet been imported. In the top menu bar, select Assets->Import Package->Custom Package..., then navigate to your local directory for the GoogleVR SDK. Select the Unity package file there to import. Your errors should now disappear and you should be able to run the scenes.

TESTING ON COMPUTER WITHOUT VR:
When you run a scene in Unity on your computer, you will enter GoogleVR's VR emulator. In this mode, you can look around by holding down Alt and moving your cursor. You can select by either clicking or pressing Ctrl.

BUILDING TO CARDBOARD:
To build onto your mobile device, you can go to File->Build Settings... Here you can select the device you want to build to. Press Build & Run with your device connected via USB to load the executable onto your device. Once you unlock the device, the program will run automatically.
