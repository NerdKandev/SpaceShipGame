using UnityEngine;

public class ShipShooting : MonoBehaviour
{
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
            if (BulletSpawner.Instance.BulettList.Count == 0) Debug.LogWarning("Cannot found prefab!!!!");
            GameObject newBullet = BulletSpawner.Instance.OnSpawn(BulletSpawner.Instance.BulettList[0], transform.position, shipRotation);
            newBullet.gameObject.SetActive(true);
        }
    }
}
