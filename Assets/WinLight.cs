using UnityEngine;
using System.Collections;

public class WinLight : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().material.color = Color.red; // initial light color is red
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Slider1") //When slider collides with Winzone, change light to green
        GetComponent<Renderer>().material.color = Color.green;
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Slider1")//When slider exits Winzone, change light to red
        GetComponent<Renderer>().material.color = Color.red;
        
    }
    //Light effects applied to all 4 lights
}
