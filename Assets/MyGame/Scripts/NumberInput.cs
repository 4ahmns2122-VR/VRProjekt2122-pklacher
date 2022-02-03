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

    public TMP_Text inputField;

    // Start is called before the first frame update
    void Start()
    {
        handy.SetActive(false);
        inputField.text = "";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Dog_Trigger")
        {
            dogBarking.Play();
        }

        if (other.name == "Handy_Trigger")
        {
            handy.SetActive(true);
            dogFound.Play();
        }


        if (other.tag == "number")
        {
            numberBeep.Play();
            string numberIn = other.name;
            telephoneNumberInput = telephoneNumberInput + numberIn;
            inputField.text = telephoneNumberInput;

            if (telephoneNumberInput == telephoneNumberRight)
            {
               
                dog.SetActive(false);
                Destroy(handy);
                numberRight.Play(); 
                glitterTreeSound.Play();
                riverSound.Play();
                puzzle1Completed = true;
            }
        }
        if(other.tag == "delete")
        {
            deleteBeep.Play();
            telephoneNumberInput = "";
        }
        
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.name == "Handy_Trigger")
        {
            handy.SetActive(false);
        }

        if (other.name == "Handy_Trigger")
        {
            Destroy(dogFound);
        }
    }

}
