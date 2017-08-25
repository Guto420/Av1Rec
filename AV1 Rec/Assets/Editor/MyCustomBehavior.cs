using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(TestMonoBehavior))]
public class MyCustomBehavior : Editor {

	public override void OnInspectorGUI ()
	{
		TestMonoBehavior tmb = target as TestMonoBehavior; 

		for (int i = 0; i < tmb.entrylist.Count; i++) {
			
			tmb.entrylist [i].value = EditorGUILayout.IntField (tmb.entrylist [i].key, tmb.entrylist [i].value);
		}


	} 

}
