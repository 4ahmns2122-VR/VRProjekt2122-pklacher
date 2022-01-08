using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogPuzzle : MonoBehaviour
{
    public GameObject handy;
    public NumerInput numberScript;

    // Start is called before the first frame update
    void Start()
    {
        handy.SetActive(false);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.name);

        if (other.name == "LeftHandController" || other.name == "RightHandBaseController")
        {
            Debug.Log("trigger handy");
            handy.SetActive(true);
        }
    }


    private void OnTriggerExit(Collider other)
    {
        //Debug.Log(other.name);

        if (other.name == "LeftHandController" || other.name == "RightHandBaseController")
        {
            Debug.Log("trigger handy leave");
            handy.SetActive(false);
        }
    }

    private void rightNumber(GameObject noHandy)
    {
        if(numberScript.telephoneNumberInput == numberScript.telephoneNumberRight)
        {
            //noHandy = handy.(DestroyObject);
        }
    }


      // Update is called once per frame
    void Update()
    {
    
    }
}
