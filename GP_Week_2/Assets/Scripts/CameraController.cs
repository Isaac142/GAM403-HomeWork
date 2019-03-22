using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player; //Creating a GameObject to control and play around with it, rather than messing around with the model.

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }


    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
