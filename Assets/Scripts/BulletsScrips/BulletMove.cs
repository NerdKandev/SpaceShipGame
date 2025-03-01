using UnityEngine;

public class BulletMove : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.5f;
    private Vector3 direction = Vector3.right;

    private void Update()
    {
        transform.parent.Translate(direction * moveSpeed * Time.deltaTime);
    }
}
