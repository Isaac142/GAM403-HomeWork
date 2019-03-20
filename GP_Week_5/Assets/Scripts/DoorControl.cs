using UnityEngine;
using System.Collections;

public class DoorControl : MonoBehaviour 
{
    //declare animator
    Animator anim;
    int open = Animator.StringToHash("Doors");

    void Start()
	{
        //assign animator
        anim = GetComponent<Animator>();

    }

    //on trigger enter, test if the collider is tagged "Player" and set trigger "Open"



    //on trigger exit, test if the collider is tagged "Player" and set trigger "Close"

    private void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.CompareTag("Player"))
        //{
        //    other.gambeObject.anim.SetTrigger(open);
        //}
    }

    private void OnTriggerStay(Collider other)
    {

    }

    private void OnTriggerExit(Collider other)
    {
        
    }

}
