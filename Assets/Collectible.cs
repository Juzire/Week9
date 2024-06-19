using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public bool isCoins, isSpeedUp;
    public int speedDuration;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            PlayerControl pc = other.GetComponent<PlayerControl>();

            if (isCoins)
            {
              pc.score++;
              Destroy(gameObject);
            }
            if (isSpeedUp)
            {
                pc.moveSpeed *= 1.5f;
            }
            
        }
    }
}
