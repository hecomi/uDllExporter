using UnityEngine;
using UnityEditor;

namespace uDllExporter
{

[CustomEditor(typeof(Test5))]
public class Test5Editor : Editor 
{
	public override void OnInspectorGUI() 
	{
		EditorGUILayout.LabelField("Test5");
		base.OnInspectorGUI();
	}
}

}