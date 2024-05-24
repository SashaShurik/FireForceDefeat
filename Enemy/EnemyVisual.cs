using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVisual : MonoBehaviour
{
     private Animator animator;

    private const string IS_RUNNINGENEMY = "IsRunning";

    private void Awake(){
        animator = GetComponent<Animator>();
    }

    private void Update() {
        
    }

}
