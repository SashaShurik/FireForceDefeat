using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // посилання на трансформ гравця
    public float smoothSpeed = 0.125f; // швидкість слідування камери за гравцем
    public float distance = 5.0f; // відстань камери від гравця

    void FixedUpdate()
    {
        if (target == null)
            return;

        Vector3 desiredPosition = target.position - (target.forward * distance);
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(target.position);
    }
}
