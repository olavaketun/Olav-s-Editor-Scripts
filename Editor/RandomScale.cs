using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

//A script allowing the user to scale selected object/s randomly along all axis.
//It includes scaling randomly from 0 to 0.1, all the way to 0 to 0.5. Not sure if it's needed but heyho.

public class RotationScale
{
	[MenuItem("Tools/Randomize/Scale/Random Scale 0.1")]
	private static void RandomizeScaleTenth()
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
				Undo.RecordObject(selectionTransforms, "Random Scale 0.1");
				
				//Add random scale to the selected objects
				selectionTransforms.localScale += new Vector3(Random.Range(0.0f, 0.1f), Random.Range(0.0f, 0.1f), Random.Range(0.0f, 0.1f));
			}
		}
	}
	
	[MenuItem("Tools/Randomize/Scale/Random Scale 0.25")]
	private static void RandomizeScaleQuarter()
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
				Undo.RecordObject(selectionTransforms, "Random Scale 0.25");
				
				//Add random scale to the selected objects
				selectionTransforms.localScale += new Vector3(Random.Range(0.0f, 0.25f), Random.Range(0.0f, 0.25f), Random.Range(0.0f, 0.25f));
			}
		}
	}
	
	[MenuItem("Tools/Randomize/Scale/Random Scale 0.5")]
	private static void RandomizeScaleHalf()
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
				Undo.RecordObject(selectionTransforms, "Random Scale 0.5");
				
				//Add random scale to the selected objects
				selectionTransforms.localScale += new Vector3(Random.Range(0.0f, 0.5f), Random.Range(0.0f, 0.5f), Random.Range(0.0f, 0.5f));
			}
		}
	}
}