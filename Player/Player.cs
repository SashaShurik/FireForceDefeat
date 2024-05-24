using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public static Player Instance { get; private set; }

    [SerializeField] private float movingSpeed = 5f;
    [SerializeField] private Camera mainCamera;
    [SerializeField] private int _damageAmount = 2;
    Vector2 inputVector;
    private Rigidbody2D rb;
    private bool isRunningFront = false;
    private bool isRunningBack = false;
    private bool isRunningLeft = false;
    private bool isRunningRight = false;
 

    private void Awake() {
        Instance = this;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start() {
        GameInput.Instance.OnPlayerAttack += GameInput_OnPlayerAttack;
    }

    private void GameInput_OnPlayerAttack(object sender, System.EventArgs e){

        }

    private void Update() {
        inputVector = GameInput.Instance.GetMovementVector(); 
    }    
          



    private void FixedUpdate() {
    HandleMovement();
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.transform.TryGetComponent(out EnemyEntity enemyEntity)) {
            enemyEntity.TakeDamage(_damageAmount);
        }
    }

  private void HandleMovement() {
        rb.MovePosition(rb.position + inputVector * (movingSpeed * Time.fixedDeltaTime));
        if (Input.GetKey(KeyCode.S)) {
            isRunningFront = true;
        } else {
            isRunningFront = false;
        }
        if (Input.GetKey(KeyCode.W)) {
            isRunningBack = true;
        } else {
            isRunningBack = false;
        }
        if (Input.GetKey(KeyCode.A)) {
            isRunningLeft = true;
        } else {
            isRunningLeft = false;
        }
        if (Input.GetKey(KeyCode.D)) {
            isRunningRight = true;
        } else {
            isRunningRight = false;
        }
    }

    public bool IsRunningFront() {
        return isRunningFront;
    }
    public bool IsRunningBack() {
        return isRunningBack;
    }
    public bool IsRunningLeft() {
        return isRunningLeft;
    }
    public bool IsRunningRight() {
        return isRunningRight;
    }
    
}