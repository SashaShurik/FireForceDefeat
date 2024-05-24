using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAi : MonoBehaviour
{
    [SerializeField] private State startingState;
    [SerializeField] private float roamingDistanceMax = 7f;
    [SerializeField] private float roamingDistanceMin = 3f;
    [SerializeField] private float roamingTimerMax = 2f;

    private NavMeshAgent navMeshAgent;
    private State state;
    private float roamingTime;
    private Vector3 roamPosition;
    private Vector3 startingPosition;

    public static Vector3 GetRandomDir(){
            return new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
        }
    private enum State{
        Roaming
    }

    private void Awake() {
        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.updateRotation = false;
        navMeshAgent.updateUpAxis = false;
        state = startingState;
    }

    private void Update() {
        switch(state){
            default:
            case State.Roaming:
                roamingTime -= Time.deltaTime;
                if(roamingTime < 0){
                    Roaming();
                    roamingTime = roamingTimerMax;
                } 
            break;       
        }    
    }

    private void Roaming(){
        startingPosition = transform.position;
        roamPosition = GetRoamingPosition();
        ChangeFacingDirection(startingPosition, roamPosition);
        navMeshAgent.SetDestination(roamPosition);
    }

     private Vector3 GetRoamingPosition(){
        return startingPosition + GetRandomDir() * UnityEngine.Random.Range(roamingDistanceMax, roamingDistanceMin);
    }
    

    private void ChangeFacingDirection(Vector3 sourcePosition, Vector3 targerPosition){
        if (sourcePosition.x > targerPosition.x){
            transform.rotation = Quaternion.Euler(0, -180, 0);
        } else {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

}
