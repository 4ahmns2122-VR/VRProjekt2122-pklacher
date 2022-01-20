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

    public bool puzzle1Completed;

    public string telephoneNumberRight = "06";
    public string telephoneNumberInput;

    public TMP_Text congratsText;

    public AudioSource numberBeep;

    // Start is called before the first frame update
    void Start()
    {
        handy.SetActive(false);
        congratsText.text = "";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Dog_Trigger")
        {
            dogBarking.Play();
        }

        if (other.name == "Handy_Trigger")
        {
            Debug.Log("trigger handy");
            handy.SetActive(true);
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
                Congrats();
                dog.SetActive(false);
                Destroy(handy);
                glitterTreeSound.Play();
            }
        }
        if(other.tag == "delete")
        {
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

    private void Congrats()
    {
        congratsText.text = "Du hast es geschafft!\nGehe weiter und löse auch die restlichen Puzzles!\n(1/3)";
        Destroy(congratsText, 15f);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
