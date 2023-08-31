using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

//A script that allows the user to disable (or enable) picking in Unity.
//Picking means whether or not you can select it through the viewport, either by clicking or box select.

public class Picking
{
	[MenuItem("Tools/Picking/Disable Picking")]
	static void DisablePicking()
	{
		//Array of selected objects
		GameObject[] selectedObject = Selection.gameObjects;
		//Disable picking for the selected objects in the array
		SceneVisibilityManager.instance.DisablePicking(selectedObject, true);
	}
	[MenuItem("Tools/Picking/Enable Picking")]
	static void EnablePicking()
	{
		//Array of selected objects
		GameObject[] selectedObject = Selection.gameObjects;
		//Enable picking for the selected objects in the array
		SceneVisibilityManager.instance.EnablePicking(selectedObject, true);
	}
}