using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraFollow : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float followSpeed;

    private void Update()
    {
        gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, 
            new Vector3(player.position.x, player.position.y, gameObject.transform.position.z), followSpeed * Time.deltaTime);
    }
}