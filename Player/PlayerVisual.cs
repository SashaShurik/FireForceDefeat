using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVisual : MonoBehaviour
{
    private Animator animator;
    private PolygonCollider2D _polygonCollider2D;

    private const string IS_RUNNINGFRONT = "IsRunningFront";
    private const string IS_RUNNINGBACK = "IsRunningBack";
    private const string IS_RUNNINGLEFT = "IsRunningLeft";
    private const string IS_RUNNINGRIGHT = "IsRunningRight";


    private void Start() {
        AttackColliderTurnOff();
    }
    public void AttackColliderTurnOff() {
        _polygonCollider2D.enabled = false;
    }

    private void AttackColliderTurnOn() {
        _polygonCollider2D.enabled = true;
    }

    private void AttackColliderTurnOnOff() {
        AttackColliderTurnOn();
         AttackColliderTurnOff();
    }

    private void Awake(){
        animator = GetComponent<Animator>();
        _polygonCollider2D = GetComponent<PolygonCollider2D>();;
    }

    private void Update() {
        animator.SetBool(IS_RUNNINGFRONT, Player.Instance.IsRunningFront());
        animator.SetBool(IS_RUNNINGBACK, Player.Instance.IsRunningBack());
        animator.SetBool(IS_RUNNINGLEFT, Player.Instance.IsRunningLeft());
        animator.SetBool(IS_RUNNINGRIGHT, Player.Instance.IsRunningRight());

        if(Input.GetKey(KeyCode.DownArrow)){  
            AttackColliderTurnOn();    
            animator.SetTrigger("IsAttackDown");
        } else {
            AttackColliderTurnOff();
        }
        if(Input.GetKey(KeyCode.UpArrow)){   
            AttackColliderTurnOn();
            animator.SetTrigger("IsAttackUp");
        } 

        if(Input.GetKey(KeyCode.LeftArrow)){   
            AttackColliderTurnOn();
            animator.SetTrigger("IsAttackLeft");
        } 
        if(Input.GetKey(KeyCode.RightArrow)){   
            AttackColliderTurnOn();
            animator.SetTrigger("IsAttackRight");
        } 

        if(HealthBar.Instance.health <= 0) {
            animator.SetTrigger("IsDead");
        }   
    } 
}
