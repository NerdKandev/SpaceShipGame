using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance { get; private set; }

    public Vector3 mouseWorldPos;

    public float onFiring;

    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Update()
    {
        GetMouseDown();
    }

    private void FixedUpdate()
    {
        GetMouseWorldPos();
    }

    public void GetMouseWorldPos()
    {
        mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    public void GetMouseDown()
    {
        onFiring = Input.GetAxis("Fire1");
    }
}
