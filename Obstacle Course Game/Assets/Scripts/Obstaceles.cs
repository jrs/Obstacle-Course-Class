using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaceles : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("The Player ran into me...");
        }
    }
}
