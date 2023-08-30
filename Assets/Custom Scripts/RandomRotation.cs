using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class RotationRotation

{
	[MenuItem("Tools/Randomize/Rotation/Random Rotation")]
	private static void RandomizeRotation180()
	{
		int selectedCount = Selection.count;
		
		//If nothing is selected, tell user to actually select something
		if (selectedCount == 0)
		{
			Debug.Log("Select a GameObject first.");
		}
		else
		{
			foreach (Transform selectionTransforms in Selection.transforms)
			{
				//Record the action so undo works
				Undo.RecordObject(selectionTransforms, "Random Rotation");
				
				//Add random rotation on the Y axis to the selected objects
				selectionTransforms.eulerAngles += Vector3.up * Random.Range(-360.0f, 360.0f);
			}
		}
	}
}