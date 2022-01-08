using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChristmastreePuzzle : MonoBehaviour
{
    private int ornaments = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update                   is called once per frame
    void Update()
    {

    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ornament")
        {
            ornaments = ornaments + 1;
            other.gameObject.SetActive(false);
            Debug.Log("Ornaments " + ornaments); 

            if(ornaments >= 5)
            {
                Debug.Log("Congrats");
            }
        }

    }
}
