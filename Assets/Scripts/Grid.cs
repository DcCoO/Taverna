using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour {
    
    public static Grid instance = null;
   
    public Item[,] grid;

    private void Awake() {
        instance = this;
    }

    // Use this for initialization
    void Start () { 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
