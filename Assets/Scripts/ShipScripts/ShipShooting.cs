using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float shootDelay = 1f;
    private float shootTimer = 0f;
    private void FixedUpdate()
    {
        ShipShootingBullet();
    }

    private void ShipShootingBullet()
    {
        if (InputManager.Instance.onFiring != 1)
        {
            return;
        }
        else
        {
            shootTimer += Time.fixedDeltaTime;
            if (shootTimer < shootDelay) return;
            shootTimer = 0f;
            Quaternion shipRotation = transform.parent.rotation;
            Instantiate(bulletPrefab, transform.position, shipRotation);
        }
    }
}
