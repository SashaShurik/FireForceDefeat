using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVisual : MonoBehaviour
{
    private Animator animator;

    private const string IS_RUNNINGFRONT = "IsRunningFront";
    private const string IS_RUNNINGBACK = "IsRunningBack";
    private const string IS_RUNNINGLEFT = "IsRunningLeft";
    private const string IS_RUNNINGRIGHT = "IsRunningRight";

    private void Awake(){
        animator = GetComponent<Animator>();
    }

    private void Update() {
        animator.SetBool(IS_RUNNINGFRONT, Player.Instance.IsRunningFront());
        animator.SetBool(IS_RUNNINGBACK, Player.Instance.IsRunningBack());
        animator.SetBool(IS_RUNNINGLEFT, Player.Instance.IsRunningLeft());
        animator.SetBool(IS_RUNNINGRIGHT, Player.Instance.IsRunningRight());
    }
}
