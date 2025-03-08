## CameraSwitcher
A Unity C# script for switching between First-Person View (FPV) and Overhead Camera View in a game. This script toggles between two camera perspectives and disables certain scripts during the overhead mode to prevent unintended player interactions.

Features
Seamless Camera Switching: Toggle between FPV and Overhead View dynamically.
Adjustable Overhead Height: Set the altitude of the overhead camera.
Script Disabling: Disables specified scripts when switching to the Overhead View, ensuring proper functionality.
How It Works
At the start, FPV Camera is enabled, and the Overhead Camera is disabled.
Calling SwitchCamera(Transform computerTransform) toggles between the two views:
When switching to Overhead View, the overhead camera moves above a specified object (e.g., a computer) and disables FPV-related scripts.
When switching back to FPV, it enables all FPV scripts again.
How to Use
Attach the script to a GameObject in your scene.
Assign the cameras:
Drag and drop the FPV Camera and Overhead Camera into the script’s fields in the Inspector.
Specify scripts to disable:
Add any scripts that should be disabled in overhead mode (e.g., player movement).
Call SwitchCamera():
Pass the transform of the object the overhead camera should focus on.
Public Variables
Variable	Type	Description
fpvCamera	Camera	Reference to the First-Person View Camera.
overheadCamera	Camera	Reference to the Overhead Camera.
fpvScripts	MonoBehaviour[]	Array of scripts to disable when in overhead mode.
overheadHeight	float	Height of the Overhead Camera above the target object.
Example Usage
csharp
Copy
Edit
void Update()
{
    if (Input.GetKeyDown(KeyCode.Tab))
    {
        cameraSwitcher.SwitchCamera(player.transform);
    }
}
Pressing Tab switches between FPV and Overhead View dynamically.

Notes
Ensure both cameras exist in the scene before running the script.
Add any scripts that should be disabled (like movement scripts) to fpvScripts.
The Overhead Camera aligns directly above the given object.
Future Enhancements
Implement smooth transitions instead of instant switching.
Add support for multiple camera angles beyond Overhead View.
