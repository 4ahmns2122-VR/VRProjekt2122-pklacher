using UnityEngine;

public class ChristmastreePuzzle : MonoBehaviour
{
    private int ornaments = 0;

    public bool puzzle3Completed;

    public NumberInput numberInputSoundControl;

 
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ornament")
        {
            ornaments = ornaments + 1;
            other.gameObject.SetActive(false);

            if(ornaments >= 5)
            {
                puzzle3Completed = true;
                numberInputSoundControl.glitterTreeSound.Stop(); 
            }
        }

    }


}
