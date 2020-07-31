using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class StartLevelScript : MonoBehaviour
{
    [SerializeField] private TilemapRenderer trapRenderer;
    [SerializeField] private Material normalTrapMat;
    [SerializeField] private Material redTrapMat;
    [SerializeField] private float timeLeft = 3.5f;
    public GameObject StartTextGO;
    public Text startText; // used for showing countdown from 3, 2, 1 

    private void Start()
    {
        GameObject.Find("Player").GetComponent<GridMovement>().enabled = false;
        transform.GetComponent<CameraFollow>().enabled = false;
        StartCoroutine(StartLevel());
        StartTextGO.SetActive(true);
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        startText.text = (timeLeft).ToString("0");
        if (timeLeft < 0)
        {
            StartTextGO.SetActive(false);
        }
    }


    private IEnumerator StartLevel()
    {
        trapRenderer.enabled = true;
        trapRenderer.material = redTrapMat;

        yield return new WaitForSeconds(3.5f);

        trapRenderer.material = normalTrapMat;
        trapRenderer.enabled = false;
        transform.GetComponent<CameraFollow>().enabled = true;
        GameObject.Find("Player").GetComponent<GridMovement>().enabled = true;
    }

    
}
