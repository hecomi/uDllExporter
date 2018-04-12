using UnityEngine;
using UnityEditor;

namespace uDllExporter
{

[CustomEditor(typeof(Test2))]
public class Test2Editor : Editor 
{
	public override void OnInspectorGUI() 
	{
		EditorGUILayout.LabelField("Test2");
		base.OnInspectorGUI();
	}
}

}