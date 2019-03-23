using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 0.05f;
    public float jump = 10f;
    //Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        //rb.GetComponent<Rigidbody> ();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(h, 0, v) * speed);

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    rb.AddForce(0, jump, 0);
                                                                            //Attempting to make character jump, player kept going halfway into ground, player gameobject had a rigidbody
                                                                            //but it pushed the body into the ground, player without these, is able to switch weapons and walk
            //Vector3 jumpVelocity = new Vector3(0, jump, 0);
            //rb.velocity = rb.velocity + jumpVelocity;
        //}
    }
}