using UnityEngine;

public class Frontdoor : MonoBehaviour
{
    public GameObject frontDoor;
    public AudioSource einleitung;


    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "LeftHandController" || other.name == "RightHandaseController") 
        {
            einleitung.Play();
            float x = frontDoor.transform.position.x - 2f;
            float y = frontDoor.transform.position.y;
            float z = frontDoor.transform.position.z;
            frontDoor.transform.position = new Vector3(x, y, z);
        }
    }

}
