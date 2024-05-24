using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour{
    public static HealthBar Instance { get; private set; }
    public float health;
    public float maxHealth;
    public Image bar;
   
    void Start()
    {
        maxHealth = health;
    }

    private void Awake(){
        Instance = this;
    }

    void Update()
    {
        bar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);
    }

}
