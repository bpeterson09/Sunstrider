using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextSpawn : MonoBehaviour {

    private SpriteRenderer render;
    public GameObject spawnpoint;

	// Use this for initialization
	void Start () {
        render = this.GetComponent<SpriteRenderer>();
        //render.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public GameObject getSpawn()
    {
        return spawnpoint;
    }
}
