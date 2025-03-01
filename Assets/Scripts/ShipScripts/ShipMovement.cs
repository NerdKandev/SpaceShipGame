using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    [SerializeField] private Vector3 worldPosition;
    [SerializeField] private float moveSpeed = 0.1f;

    private void FixedUpdate()
    {
        GetTargetPosition();
        Moving();
        LookAtTarget();
    }

    private void GetTargetPosition()
    {
        worldPosition = InputManager.Instance.mouseWorldPos;
        worldPosition.z = 0;
    }

    private void LookAtTarget()
    {
        float angleRad = Mathf.Atan2(InputManager.Instance.mouseWorldPos.y - transform.position.y, InputManager.Instance.mouseWorldPos.x - transform.position.x);
        float angleDeg = (180 /  Mathf.PI) * angleRad;

        transform.parent.rotation = Quaternion.Euler(0f, 0f, angleDeg);
        Debug.DrawLine(transform.parent.position, InputManager.Instance.mouseWorldPos, Color.white, Time.deltaTime);
    }

    private void Moving()
    {
        Vector3 newPos = Vector3.Lerp(transform.parent.position, worldPosition, moveSpeed);
        transform.parent.position = newPos;
    }
}
