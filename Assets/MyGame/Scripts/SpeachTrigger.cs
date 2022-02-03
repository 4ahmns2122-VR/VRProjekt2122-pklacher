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

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "NoteTrigger")
        {
            Destroy(doorNote);
        }

        if (other.name == "TreeSpeachTrigger")
        {
            Destroy(tree);
        }

        if (other.name == "ChristmastreeSpeachTrigger")
        {
            Destroy(foundChristbaum);
        }

        if (other.name == "Key")
        {
            Destroy(foundKey);
        }
    }
}
