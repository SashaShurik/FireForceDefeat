using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePos : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;

    void Update()
    {
        Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;
        Collider2D collider = Physics2D.OverlapPoint(mouseWorldPosition);
        if(Input.GetMouseButtonDown(0)){    
            if(collider != null)
            {
                Debug.Log("collider hit: " + collider.gameObject.name);
            }
        }
    }
}