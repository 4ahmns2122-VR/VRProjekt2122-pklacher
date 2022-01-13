using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChristmastreePuzzle : MonoBehaviour
{
    private int ornaments = 0;

    public TMP_Text congratsText;

    // Start is called before the first frame update
    void Start()
    {
        congratsText.text = "";
    }

    // Update                   is called once per frame
    void Update()
    {

    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ornament")
        {
            ornaments = ornaments + 1;
            other.gameObject.SetActive(false);
            Debug.Log("Ornaments " + ornaments); 

            if(ornaments >= 5)
            {
                Congrats();
            }
        }

    }

    private void Congrats()
    {
        congratsText.text = "Du hast es geschafft!\nGehe nun zurück zum Haus deines Nachtbarn für deinen Haustürschlüssel!\n(3/3)";
        Destroy(congratsText, 15f);
        
    }

}
