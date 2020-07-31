using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speech : MonoBehaviour
{
    [SerializeField] private GameObject SpeechBubble;
    [SerializeField] private GameObject OW;
    [SerializeField] private GameObject Shiny;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Diamond")
        {
            OW.SetActive(false);
            SpeechBubble.SetActive(true);
            Shiny.SetActive(true);

            StartCoroutine(WaitTime());
        }

        if (collision.gameObject.tag == "Trap")
        {
            Shiny.SetActive(false);
            SpeechBubble.SetActive(true);
            OW.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Trap")
        {
            SpeechBubble.SetActive(false);
            OW.SetActive(false);
        }
    }

    private IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(.7f);
        SpeechBubble.SetActive(false);
        Shiny.SetActive(false);
    }
}

