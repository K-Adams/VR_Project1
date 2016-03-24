using UnityEngine;
using System.Collections;
using System.IO;


public class Datamanager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		string filepath = System.IO.Path.Combine (Application.streamingAssetsPath, "top10tallestbuildings.csv");
		string[] line = System.IO.File.ReadAllLines (filepath);

		string[] rank1 = line [1].Split (',');
		Debug.Log ("Got line 1");
		string[] rank2 = line [2].Split (',');
		Debug.Log ("Got line 2");
		string[] rank3 = line [3].Split (',');
		Debug.Log ("Got line 3");
		string[] rank4 = line [4].Split (',');
		Debug.Log ("Got line 4");
		string[] rank5 = line [5].Split (',');
		Debug.Log ("Got line 5");

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
