using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Picking : MonoBehaviour

{
	[MenuItem("Tools/Picking/Disable Picking")]
	static void DisablePicking()
	{
		//Array of selected objects
		GameObject[] selectedObject = Selection.gameObjects;
		//Record the action so undo works
		Undo.RecordObject(selectedObject, "Disable Picking");
		//Disable picking for the selected objects in the array
		SceneVisibilityManager.instance.DisablePicking(selectedObject, true);
	}
	[MenuItem("Tools/Picking/Enable Picking")]
	static void EnablePicking()
	{
		//Array of selected objects
		GameObject[] selectedObject = Selection.gameObjects;
		//Record the action so undo works
		Undo.RecordObject(selectedObject, "Enable Picking");
		//Enable picking for the selected objects in the array
		SceneVisibilityManager.instance.EnablePicking(selectedObject, true);
	}
}