using UnityEngine;

public class SpeachTrigger : MonoBehaviour
{
    public AudioSource doorNote;
    public AudioSource tree;
    public AudioSource foundChristbaum;
    public AudioSource foundKey;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "NoteTrigger")
        {
            doorNote.Play();
        }

        if (other.name == "TreeSpeachTrigger")
        {
           tree.Play();
        }

        if (other.name == "ChristmastreeSpeachTrigger")
        {
            foundChristbaum.Play();
        }

        if (other.name == "Key")
        {
            foundKey.Play();
        }
    }
}
