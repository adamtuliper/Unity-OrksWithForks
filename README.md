<a name="HOLTop" />
# Introduction to Unity #

----------------

<a name="Overview" />
## Overview ##

Unity is a major player in the cross platform game engine space with over 21 supported platforms, including Windows 10 , MacOS, Linux , Android and iOS. All of which can use the same code base. In this workshop you will builds Orks with Forks (and Knives) - a fun top down 2D game. Keep in mind Unity is not a 3D asset creation system, but instead a system you can arrange your assets, write code to animate, use physics, audio, and more. There are other software packages such as Autodesk Maya or Blender that can be used to 3D model, although Unity does have a built in terrain modelling system. 

![alt](/Images/Orks Screenshot.PNG)

<a name="Objectives" />
### Objectives ###

In this module, you will see how to:

- Use Unity's Editor to design a 2D level with sprites
- Handle User Input
- Work with the Camera
- Handle Input from Keyboard


<a name="Prerequisites"></a>
### Prerequisites ###

The following is required to complete this module:

- [Visual Studio Community 2015][1] or greater.
- [Unity 5.3][2] or greater.

[1]: https://www.visualstudio.com/products/visual-studio-community-vs
[2]: unity3d.com

<a name="CodeSnippets" />
### Using the Code Snippets ###

Throughout the module document, you will be instructed to insert code blocks. For your convenience, most of this code is provided as Visual Studio Code Snippets, which you can access from within Visual Studio 2015 to avoid having to add it manually. 

>**Note**: Each exercise is accompanied by a starting solution located in the **Begin** folder of the exercise that allows you to follow each exercise independently of the others. Please be aware that the code snippets that are added during an exercise are missing from these starting solutions and may not work until you have completed the exercise. Inside the source code for an exercise, you will also find an **End** folder containing a complete Unity Project with the code and assets that result from completing the steps in the corresponding exercise. You can use these solutions as guidance if you need additional help as you work through this module. Unity can open multiple instances at a time as well as multiple versions of Unity can exist happily on your system and run at the same time as well.

---

<a name="Exercises" />
## Exercises ##
This module includes the following exercise:

1.  [Getting Started : Creating your first game](#Exercise1)

Estimated time to complete this module: **60 minutes**

>**Note:** When you first start Visual Studio, you must select one of the predefined settings collections. Each predefined collection is designed to match a particular development style and determines window layouts, editor behavior, IntelliSense code snippets, and dialog box options. The procedures in this module describe the actions necessary to accomplish a given task in Visual Studio when using the **General Development Settings** collection. If you choose a different settings collection for your development environment, there may be differences in the steps that you should take into account.

<a name="Getting Started" />
### Getting Started : Creating your first game ###

In this exercise you will create your first Unity game. But first let's explore the Editor interface in Unity.
The Hierarchy window (1) contains everything in your scene. A scene is essentially a level in your game. When the game loads, it will load the first scene in your build settings (control-shift-b) or if you are working in the Editor, the current scene will load when you play test your game.
The Scene tab(2) contains your design surface for your level. Here you drag/drop objects and arrange your objects. Next is the Game window (3) where you will see your game when test playing it. The Play bar (4) allows you to play your game right in Unity without having to build externally. It also allows you to pause and run your game one frame at a time. After that is the Inspector window (5) that has the properties of the currently seleccted Game Object. Finally the Project window (6) is what contains all of the art, models, images, scripts, audio, and files (assets) that make up your project.

![The Editor](/Images/Editor.PNG "The Editor")

Unity's Asset Store allows you to buy (or get some for free) various assets related to your game. 
AssetStore

![The Asset Store](/Images/AssetStore.PNG "The Asset Store")

<a name="Ex1Task1" />
#### Task 1 - Open Project and Scene ####

To get started we need to open the starter Unity Project and find the scene file. Scenes are your levels in Unity. You will need to find your scene and open it to start working on it, just as you would have to find a web page to work on in a web project. The project may or may not load with it already open, so it is important to understand how to find them.

1. Open Unity
2. Choose "Open Project" 
3. Select the project folder on the desktop "OrksWithForks Starter"
4. Unity will re-open and load the project. 
5. When Unity opens, find the scene file /Assets/Scenes/scene01 and double click it to open it.

![Open Scene 01](/Images/Scene.PNG)

<a name="Ex1Task2" />
#### Task 2 - Run the game and modify camera settings ####

Note the Play, Pause, and Frame Advance button on the toolbar. This allows you to play your game without having to manually compile and export a build. Mono is used as the runtime for your scripts (Plus the native engine code) and Unity runs it right in the editor.
When you click play, you'll go into Play Mode. This is a temporary testing mode and most changes you make will be lost so it is important to know when you are in play mode. 

Everything in your game is visible because of a camera. There are two camera types in Unity - Orthographic and Perspective. These are simply options on a camera component. Perspective cameras see the world as we do, Orthographic cameras have no scaling with distance, which is good for 2D games. Also Othergraphic camera size keeps a fixed height no matter the screen we are running the game on. The only thing that varies is how much width is visible.

![Wide View with Orthographic Camera](/Images/OrthoWide.PNG "Wide View with Orthographic Camera")
_Orthographic Camera, Note the height

![Thin View with Orthographic Camera](/Images/OrthoThin.PNG "Thin View with Orthographic Camera")

_Orthographic Camera, Note the height is still the same with a thinner screen_


1. Click play on the toolbar and run the game.

![Play Bar](/Images/PlayBar.PNG "Play Bar")
2. Move across the screen to the exit. Note the camera doesn't follow.
3. When you are done make sure you click play again to get out of play mode.
4. In the project window at the bottom, Navigate to /Scripts/
5. Drag and drop the CameraFollow.cs script onto the Camera Game Object in the hierarchy.  
6. Click play again and notice how the camera now follows the character.
7. Get out of play mode.
8. ** Verify you are not in play mode ** Press Control-S to save your scene. If you are in play mode you'll get an error.
9. In the hierarchy window, select the Camera game object.

<img src="/Images/CameraSelected.PNG" alt="Camera Game Object" width="100px" />

![Camera Game Object](/Images/CameraSelected.PNG "Camera Game Object")
10. In the Inspector window, change the size on the orthographic camera component to customize how much vertical height the user will see no matter the device they run it on.

![Orthographic Height](/Images/CameraSize.PNG "Orthographic Height")

<a name="Ex1Task3" />
#### Task 3 - Organize the Hierarchy Window ####

The hierarchy window is a bit messy. It lists all of the game objects in the current scene. A game object is a container for other objects and also components which bring your game objecs to life. Every item in the hierarchy is a game object, which may or may not have any visible properties. Let's organize this window a bit more. 

1. Select the menu GameObject / Create Empty
2. Rename this new game object to "Enemies"
    Ensure you press Enter when done (don't just click away)
    
    ![Renaming Enemies](/Images/InspectorEnemies.PNG "Renaming Enemies")
3. In the Hierarchy window only, drag and drop the Orks and Goblin onto this new game object.

![Collapse Game Objects](/Images/CollapseGameObjects.PNG)
4. In the hierarchy window, locate the Environment game object. There's already a bunch of objects underneath it.
5. In the Hierarchy window only, drag and drop all the 'walls' onto the "Environment" game object to clean up the view
    You can control-click or click one and shift click another item, jsut as you would in Windows Explorer to select files. 
6. Collapse the Environment and Enemies game objects to clean up the hierarchy view 

   ![Drag Onto Environment](/Images/DragToEnvironment.PNG "Drag Onto Environment")
    

<a name="Ex1Task4" />
#### Task 4 - Add Level Pieces  ####

Prefabs are a concept in Unity of a 'prefabricated object'. These are game object settings, components like physics and scripts. Our walls need to have physics on them. 

The level is incomplete. The left edge has been removed. Add some level pieces from the /Prefabs folder to build out the level a bit more.

1. Use the /Sprites/Floors folder to drag/drop sprites into the Scene tab to draw out a floor plan.
    This folder is being used because we can simply run across an image. The case we need ot handle is how we stop at a wall
2. Use the /Prefabs folder to drag/drop walls into the scene and draw the level.
    The walls are ordered by top/bottom after each center piece. Because of the top down scaling perspective view, the walls on each side of the center pieces have bricks directed in opposite directions. Enemies will move until they hit any object with a collider on it.
3. Now the tricky part. Vertex snapping. In order to get everything in place all night and neat we need to snap one vertex to the next closest vertex. Hold down V and mouse near the edge of a piece you want to snap to another.

    ![Vertex Snap](/Images/VertexSnap.PNG "Vertex Snap")
    
<a name="Ex1Task5" />
#### Task 5 - Read basic input and move the player ####

Before we look at adding code to a more complete version of the player, let's take a look at some simple mechanics to make our player move. In Unity when we want to work with any game object we typically get a reference to a component via a GetComponent<> function call.

1. Open the scene /Scenes/SimplePlayer
2. Locate the game object "Player" in the Hierarchy window.
3. Look in the Inspector window at the components that bring this Game Object to life. We use various components in code to control an object

Sprite Renderer - Displays a 2D image on the screen

Animator - Controls the Sprite Renderer to play different images to animate this game object

RigidBody 2D - Give this object mass and make it under the influence of gravity

Circle Collider 2D - Give this object a shaoe the physics engine will use to simulate physics. The object will act like its a circle shape from a physics standpoint (collisions)

 
    ![Inspector Window for the Player](/Images/InspectorSimplePlayer.PNG "Inspector Window for the Player")
4. Click Play and notice that using the arrow keys we cannot control out player.
5. Get out of play mode
6. Open up /Scripts/SimplePlayer.cs and find the Start() method. Notice that here we ask Unity for this Game Object's RigidBody component by simply calling the following method. This component is how we'll eventually move our Player.
```csharp
         _rigidBody = GetComponent<Rigidbody2D>();
```
7. Back in Unity's Editor, Open Edit/Project Settings/Input.  Note the Input settings for Horizontal are A/D or Left/Right arrow keys.

![Input Manager Horizontal](/Images/InputHorizontal.PNG "Input Manager Horizontal")
8. Locate the Update() method back in Visual Studio. Here we will need to read  input (left/right up/down or ASDW keys). Replace the //TODO content in the Update() method so the code is complete as per below

```csharp
    void Update () {
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");
    }
```
9. Our input has a value of -1 to +1 for both Horizontal and Veritcal. We can use these values read in Update() (which is where keyboard input should be read) and apply those values in FixedUpdate, which is where we typically do physics operations.
Replace the //ToDo line with the method content below. This will set the velocity in meters/second of our game object. Note that we'll max out at 1 m/s in each direction because our input only goes from -1 to +1.

```csharp
    void FixedUpdate()
    {
        //Move the actual object by setting its velocity
        _rigidBody.velocity = new Vector2(_horizontal, _vertical);
     }
```
10. Save your changes and go back to Unity. There will be a brief pause while Unity compiles your code automatically, no work is needed. You can view any errors in the Console window. You shouldn't have any, this is just an FYI that errors will show up here and also in Visual Studio, although performing a build in Visual Studio is _not_ necessary. Drag and Drop the SimplePlayer.cs script onto the Player game object. 

  ![Console Errors](/Images/ConsoleErrors.PNG "Console Errors")
11. Press Control-S to save your Unity scene changes and then click play to run the Unity project. Press the left/right up/down arrows or ASDW keys to move the character around.

  ![Play Simple PLayer](/Images/PlaySimplePlayer.PNG "Play Simple Player")

<a name="Ex1Task6" />
#### Task 6 - Allow the player to play the attack and walk animations ####

Now that we see how to apply basic movement, let's add code to allow the character to play an animation that has been setup already.
This animation will be triggered by "Fire1", which according to the input system is the left control key or the first mouse button (mouse 0 - ie left click). When we asked for Input previously, we used GetAxis. To check for buttons we can use GetButtonDown (or GetButton, GetButtonUp)

![Input Manager](/Images/InputManager.PNG "Input Manager")

1. In the /Scripts/SimplePlayer.cs file, find the empty Update() method again and add the following code to it. This will run every frame and check for Fire1. It will only be true once and that's during the frame that runs and finds it held down. If the button is held down, this will not repeat, although that is possibe to do with GetButton() 
```csharp
    void Update()
    {
    
        //existing code here
        
        //Now add this code
        if (Input.GetButtonDown("Fire1"))
        {
            _animator.SetTrigger("Attack");
        }
    }
```

2. Save your code and go back to Unity. There will be a few second pause while your code is compiled by Unity.
3. Click Play to test out the changes. You should now get a walking animation when you move and an attack animation when you press the left mouse button or left control key.

<a name="Ex1Task7" />
#### Task 7 - Add a trigger to the coin to allow the play to detect it  ####

In Unity, we can detect when one object has come within range of another object in several ways, one of them being what's called a Trigger. The other is a collider. A collider will stop one object from passing through another. A trigger is a special case of a collider that allows objects to pass through but gives us the opportunity to be notified in code when object A intersects with object B. A collider/trigger is simply a predefined shape (sphere, box, capsule, etc) that the physics engine uses. It doesn't matter what an objeect physically looks like to determine how it behaves physically, that is determined by the collider/trigger shape.

1. Find a coin in the scene and click on it. It may help to press T to select the 2D tool.
2. Right click on the coin in the Hierarchy and choose "Select Prefab". This coin is a prefab, thats why it is blue in the Hierarchy window. This is an instance of a shared object in your project folder. If you change the shared object, you'll change every instance of that coin. 
3. In the Project Window, ensure the coin is highlighted. Note - we're talking about the project window note not the Hierarchy window. Click the Add Component button and type in Circle
![Add Circle Collider](/Images/AddCircleCollider.PNG "Add Circle Collider")
4. On the newly added component, check off IsTrigger. This will turn it from an immoveable object to something you can run through (ie - pick up)
![Check Off IsTrigger](/Images/IsTrigger.PNG "Check Off IsTrigger")
5. Notice that any coin you click on now has this trigger on it.
6. Open the /Scenes/scene01 and find the Player game object near the top of the hierarchy. Note that this game object has a PlayerController script which is a more completed version of the SimplePlayer script.
7. Open the /Scripts/PlayerController.cs file either by double clicking on it or double clicking on it from the Inspector for the Player game object
![Select Script from Inspector](/Images/SelectScriptFromInspector.PNG "Select Script from Inspector")
8. Find the OnTriggerEnter2D method. This will get called when the player runs over any objects with a 2D trigger on it, like we created for the coin.
9. Uncomment the code for the first TODO. This will increment our coin score when we run over a coin. We know we run over a coin because it has a tag. A tag is just text we can use to identity an object. You can create your own tags and then assign them in a dropdown list for an object. Here's an image showing the coin tag that is set. 
![Coin Tag](/Images/CoinTag.PNG "Coin Tag") 
10. Find the "TODO - destroy game object we just picked up and replace it with the code shown below. Our completed code now looks like the following. Notice how we check the tag of the object we've just intersected (triggrered) with
```csharp
        if (collision.gameObject.tag == "Coin")
        {
            //Get its coin score
            var pickupProperties = collision.gameObject.GetComponent<PickupProperties>();
            CoinUp(pickupProperties.CoinAmount);

            Destroy(collision.gameObject);
        }
```        
11. Save your code and go back to Unity's Editor and play your game. When you run over coins now you should see them disappear and your coin score increase.
            
<a name="Ex1Task8" />
#### Task 8 - Add the Walk animation ####

<a name="Summary" />
## Summary ##

