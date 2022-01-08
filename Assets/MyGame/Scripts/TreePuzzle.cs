using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreePuzzle : MonoBehaviour
{
    public GameObject tree;
    public GameObject axe;

    private bool gotAxe = false;

    private int triggerCount = 0;

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
        if (other.name == "Axe")
        {
            gotAxe = true;
            axe.SetActive(false);
        }

        if (other.name == "Tree" & gotAxe)
        {
            triggerCount = triggerCount + 1;
            Debug.Log("Axe Hits: " + triggerCount);

            if(triggerCount == 3)
            {
                tree.transform.Rotate(0, 0, -90);
                tree.transform.position = new Vector3(transform.position.x, -1.29f, transform.position.z);
            }
            
        }


    }
}
