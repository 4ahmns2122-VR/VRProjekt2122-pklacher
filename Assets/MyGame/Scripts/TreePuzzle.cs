using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TreePuzzle : MonoBehaviour
{
    public GameObject tree;
    public GameObject axe;

    private int triggerCount = 0;

    public TMP_Text congratsText;

    // Start is called before the first frame update
    void Start()
    {
        congratsText.text = "";
    }

    // Update is called once per frame
    void Update()
    {

    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Axe")
        {
            triggerCount = triggerCount + 1;
            Debug.Log("Axe Hits: " + triggerCount);

            if (triggerCount == 3)
            {
                axe.SetActive(false);
                tree.transform.Rotate(0, 0, -90);
                tree.transform.position = new Vector3(transform.position.x, -1.29f, transform.position.z);
                Congrats();
            }
        }



    }

    private void Congrats()
    {
        congratsText.text = "Du hast es geschafft!\nGehe weiter und löse auch die restlichen Puzzles!\n(2/3)";
        Destroy(congratsText, 15f);
    }
}
