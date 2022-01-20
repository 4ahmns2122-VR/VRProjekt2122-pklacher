using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KeyBackdoor : MonoBehaviour
{
    public GameObject key;
    public GameObject door;
    //public Animator anim;

    public NumberInput puzzle1;
    public TreePuzzle puzzle2;
    public ChristmastreePuzzle puzzle3;

    // Start is called before the first frame update
    void Start()
    {
        key.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (puzzle1.puzzle1Completed && puzzle2.puzzle2Completed && puzzle3.puzzle3Completed)
        {
            key.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Key")
        {
            Destroy(door);
        }
    }
}
