using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawController : MonoBehaviour {


    private GameObject theSaw;
    public float speedRotation;

    // Use this for initialization
    void Start () {
        theSaw = FindObjectOfType<GameObject>();
    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 0, Time.deltaTime * -speedRotation);
    }
}
