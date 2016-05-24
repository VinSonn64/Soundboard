using UnityEngine;
using System.Collections;

public class Win : MonoBehaviour {

    public int Click;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter() //Add a point when slider enters winzone
    {
            Click += 1;
        if(Click==8)//Points add up for the win
            // 8 points beacuse 4 points are added because the zone for changing lights and zone for detecting sliders are colliding.
        { print("You Win!"); }
    }
    void OnTriggerExit()//Lose point when slider exits winzone.
    {
            Click -= 1;
    }
}
