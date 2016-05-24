using UnityEngine;
using System.Collections;

public class WinLight4 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().material.color = Color.red; 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Slider4")
            GetComponent<Renderer>().material.color = Color.green;
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Slider4")
            GetComponent<Renderer>().material.color = Color.red;

    }
}
