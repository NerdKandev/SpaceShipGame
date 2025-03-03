using UnityEngine;

public class LoadBehaviour : MonoBehaviour
{
    private void Reset()
    {
        LoadComponents();
    }

    private void Awake()
    {
        LoadComponents();
    }
    protected virtual void LoadComponents()
    {
    
    }
}
