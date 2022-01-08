using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumerInput : MonoBehaviour
{
    public GameObject handy;
    public GameObject dog;

    //public DogPuzzle dopPuzzleScript;

    public string telephoneNumberRight = "06";
    public string telephoneNumberInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "number")
        {
            Debug.Log("input number");
            string numberIn = other.name;
            telephoneNumberInput = telephoneNumberInput + numberIn;
            Debug.Log(telephoneNumberInput);

            if (telephoneNumberInput == telephoneNumberRight)
            {
                Debug.Log("Congrats");
                //dog.SetActive(false);


            }
        }
        if(other.tag == "delete")
        {
            telephoneNumberInput = "";
            Debug.Log("delete");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
