using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberInput : MonoBehaviour
{
    public GameObject handy;
    public GameObject dog;

    public AudioSource dogBarking;
    public AudioSource glitterTreeSound;
    public AudioSource riverSound;

    public bool puzzle1Completed;

    public string telephoneNumberRight = "06";
    public string telephoneNumberInput;

    public AudioSource numberBeep;
    public AudioSource deleteBeep;
    public AudioSource dogFound;
    public AudioSource numberRight;

    // Start is called before the first frame update
    void Start()
    {
        handy.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Dog_Trigger")
        {
            dogBarking.Play();
            handy.SetActive(true);
            dogFound.Play();
        }


        if (other.tag == "number")
        {
            numberBeep.Play();
            Debug.Log("input number");
            string numberIn = other.name;
            telephoneNumberInput = telephoneNumberInput + numberIn;
            Debug.Log(telephoneNumberInput);

            if (telephoneNumberInput == telephoneNumberRight)
            {
               
                dog.SetActive(false);
                Destroy(handy);
                numberRight.Play(); 
                glitterTreeSound.Play();
                riverSound.Play();
            }
        }
        if(other.tag == "delete")
        {
            deleteBeep.Play();
            telephoneNumberInput = "";
            Debug.Log("delete");
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        //Debug.Log(other.name);

        if (other.name == "Handy_Trigger")
        {
            Debug.Log("trigger handy leave");
            handy.SetActive(false);
        }
    }



    // Update is called once per frame
    void Update()
    {
    }
}
