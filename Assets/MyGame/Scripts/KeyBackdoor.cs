using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBackdoor : MonoBehaviour
{
    public Rigidbody door;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Key")
        {
            door.AddForce(0, 0, 250);
        }
    }
}
