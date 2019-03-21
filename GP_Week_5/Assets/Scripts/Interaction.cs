using UnityEngine;
using System.Collections;

public class Interaction : MonoBehaviour
{

    public GameObject fanModel;
    public GameObject lightModel;
    public Light lightColor;
    public ParticleSystem particleSystem1;
    public ParticleSystem particleSystem2;
    public Color changingColor;
    //declare public variables for light, lightModel, particle systems, fan model


    // Update is called once per frame
    void Update()
    {

        //if fan rotation is on, transform.rotate

        //if mouse button is down

        //setup ray from camera to clicked mouseposition.

        //if Physics.Raycast
        //https://docs.unity3d.com/ScriptReference/Physics.Raycast.html
        // Look for Raycast with Input.mousePosition
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100))
            Debug.DrawLine(ray.origin, hit.point);
        //    //if ray hits game object tagged "Light"

        //    //change light model material to green
        //    //change point light color to green
        //    //SetActive both particle systems
        //    //turn on rotation (called in main Update function)
        //}
    }

    private void FixedUpdate()
    {
        //&& gameObject.CompareTag("Light")
        if (Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                print(hit.collider.name);

                if (hit.collider.CompareTag("Light"))
                    {
                    lightModel.GetComponent<Renderer>().material.color = changingColor;
                    lightColor.color = Color.green;
                    particleSystem1.gameObject.SetActive(true);
                    particleSystem2.gameObject.SetActive(true);
                    //fanModel.transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
                }
            }

            Debug.DrawLine(ray.origin, hit.point);
        }
    }
}