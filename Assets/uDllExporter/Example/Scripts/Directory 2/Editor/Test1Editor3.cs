using UnityEngine;
using UnityEditor;

namespace uDllExporter
{

[CustomEditor(typeof(Test3))]
public class Test3Editor : Editor 
{
	public override void OnInspectorGUI() 
	{
		EditorGUILayout.LabelField("Test3");
		base.OnInspectorGUI();
	}
}

}