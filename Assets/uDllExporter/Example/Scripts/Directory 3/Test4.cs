using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

namespace uDllExporter
{

public class Test4 : MonoBehaviour 
{
	[SerializeField]
	Text text;

	[SerializeField]
	NetworkManager networkManager;

	void Start()
	{
		Debug.Log("Test4");
	}
}

}