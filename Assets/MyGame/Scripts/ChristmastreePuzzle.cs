using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChristmastreePuzzle : MonoBehaviour
{
    private int ornaments = 0;

    public bool puzzle3Completed;

    public NumberInput numberInputSoundControl;

 

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
                Destroy(numberInputSoundControl); 
            }
        }

    }


}
