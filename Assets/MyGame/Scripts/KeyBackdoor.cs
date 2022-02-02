using UnityEngine;
using TMPro;


public class KeyBackdoor : MonoBehaviour
{
    public GameObject key;
    public GameObject door;
    public GameObject note;

    public NumberInput puzzle1;
    public TreePuzzle puzzle2;
    public ChristmastreePuzzle puzzle3;

    public TMP_Text congratsText;


    // Start is called before the first frame update
    void Start()
    {
        congratsText.text = "";
        key.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (puzzle1.puzzle1Completed && puzzle2.puzzle2Completed && puzzle3.puzzle3Completed)
        {
            key.SetActive(true);
            note.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Key")
        {
            Congrats();
            Destroy(door);
        }
    }

    private void Congrats()
    {
        congratsText.text = "Du hast es geschafft!\nGratulation!";

    }
}
