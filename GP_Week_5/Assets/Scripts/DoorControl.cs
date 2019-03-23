using UnityEngine;
using System.Collections;

public class DoorControl : MonoBehaviour 
{
    //declare animator
    public Animator anim;

    void Start()
	{
        //assign animator
        anim = GetComponent<Animator>();

    }

    //on trigger enter, test if the collider is tagged "Player" and set trigger "Open"



    //on trigger exit, test if the collider is tagged "Player" and set trigger "Close"

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            anim.SetTrigger("DoorOpen");

    }

    private void OnTriggerStay(Collider other)
    {

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            anim.SetTrigger("DoorClose");
        }
    }

}
