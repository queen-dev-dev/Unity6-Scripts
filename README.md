# Unity6-Scripts
A place full of Unity 6 scripts that make game development faster.

# menuSpawner.cs
I made menuSpawner.cs to make dynamic sprite spawning much easier rather than having to hard code it all.
Right now it only works for 2D projects but I can work on the script once I am finished with my project to allow for 3D compatibility.
## Instructions
In the scene that you want to use the script in, attach the script to a blank game object.
You will then see a setting called 'Prefab Base'. You must put a prefab with a Rigidbody2D attached to it in this slot.
Moving on, you will see the spawnlist with an integer input value - the integer is how many items will be in the spawnlist. You can use this instead of repeatedly clicking on the + or - icons a bunch of times.
Each item in the spawnlist lets you assign a name to the prefab, choose which sprite to spawn it with, where it should start and where it should move to.
In settings, both move duration and spawn delay is in seconds.
That's all!

All of the tweening for this script is made with the DOTween plugin for Unity which I found here: https://assetstore.unity.com/packages/tools/animation/dotween-hotween-v2-27676#description
