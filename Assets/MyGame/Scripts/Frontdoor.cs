using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frontdoor : MonoBehaviour
{
    public GameObject frontDoor;
    public AudioSource music;
    public AudioSource einleitung;


    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "LeftHandController" || other.name == "RightHandaseController") 
        {
            Debug.Log("Trigger Enter");
            music.Play();
            einleitung.Play();
            float x = frontDoor.transform.position.x - 2f;
            float y = frontDoor.transform.position.y;
            float z = frontDoor.transform.position.z;
            frontDoor.transform.position = new Vector3(x, y, z);
        }
    }

    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.name == "LeftHandController" || other.name == "RightHandaseController")
    //    {
    //        Debug.Log("Trigger Exit");
    //        float x = frontDoor.transform.position.x + 2f;
    //        float y = frontDoor.transform.position.y;
    //        float z = frontDoor.transform.position.z;
    //        frontDoor.transform.position = new Vector3(x, y, z);
    //    }
    //}
}
