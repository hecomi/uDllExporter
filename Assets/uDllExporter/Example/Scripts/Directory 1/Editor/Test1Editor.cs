using UnityEngine;
using UnityEditor;

namespace uDllExporter
{

[CustomEditor(typeof(Test1))]
public class Test1Editor : Editor 
{
	public override void OnInspectorGUI() 
	{
		EditorGUILayout.LabelField("Test1");
		base.OnInspectorGUI();
	}
}

}