using UnityEngine;
using System.Collections;

public class Barrier : MonoBehaviour {
    public int lifespan = 1000;
    int timer = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timer++;

        if(timer >= lifespan)
        {
            GameObject.Destroy(this.gameObject);
        }
    }
}
