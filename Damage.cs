using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public HealthBar pHealth;
    public float damage;

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Player")){
            pHealth.health -= damage;
        }
    }

}
