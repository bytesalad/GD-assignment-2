using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageFlashlightDuration : MonoBehaviour
{
    [SerializeField] private PlayerFlashlight flashlightScript;
    [SerializeField] private Image flashLightDurationImage;

    private void Update()
    {
        flashLightDurationImage.fillAmount = flashlightScript.getDuration();
    }
}
