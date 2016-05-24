using UnityEngine;
using System.Collections;

public class CharController : MonoBehaviour
{
    private float moveVertical;
    public float speed = 10f;
        
    // Use this for initialization
    void Start()
    {
        GetComponent<Renderer>().material.color = Color.blue;//Makes the slider blue
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey("1")) //Holding down a key to select specific slider
        {
            if (gameObject.tag == "Slider1")
            {

                moveVertical = Input.GetAxis("Vertical");

                Vector3 movement = new Vector3(0.0f, 0.0f, moveVertical); //movement for player, restricted to the z-axis

                this.GetComponent<Rigidbody>().AddForce(movement * speed); //speed of player
            }


        }



        if (Input.GetKey("2"))
        {
            if (gameObject.tag == "Slider2")
            {

                moveVertical = Input.GetAxis("Vertical");

                Vector3 movement = new Vector3(0.0f, 0.0f, moveVertical); //movement for player

                this.GetComponent<Rigidbody>().AddForce(movement * speed); //speed of player
            }


        }

        if (Input.GetKey("3"))
        {
            if (gameObject.tag == "Slider3")
            {

                moveVertical = Input.GetAxis("Vertical");

                Vector3 movement = new Vector3(0.0f, 0.0f, moveVertical); //movement for player

                this.GetComponent<Rigidbody>().AddForce(movement * speed); //speed of player
            }


        }

        if (Input.GetKey("4"))
        {
            if (gameObject.tag == "Slider4")
            {

                moveVertical = Input.GetAxis("Vertical");

                Vector3 movement = new Vector3(0.0f, 0.0f, moveVertical); //movement for player

                this.GetComponent<Rigidbody>().AddForce(movement * speed); //speed of player
            }


        }



    }

   /* void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reset")
        {
            transform.position = new Vector3(0, 2, 0);
        }
    }
    */
    

}