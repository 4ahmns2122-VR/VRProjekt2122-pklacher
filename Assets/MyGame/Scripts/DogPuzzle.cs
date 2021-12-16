using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogPuzzle : MonoBehaviour
{
    public GameObject handy;
    // Start is called before the first frame update
    void Start()
    {
        handy.SetActive(false);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);

        if (other.name == "LeftHandController" || other.name == "RightHandBaseController")
        {
            Debug.Log("´JUHUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUU");
            //handy.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
