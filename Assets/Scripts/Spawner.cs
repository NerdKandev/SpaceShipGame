using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spawner : LoadBehaviour
{
    [SerializeField] private List<Transform> prefabs = new List<Transform>();

    protected override void LoadComponents()
    {
        LoadPrefabs();
    }

    private void LoadPrefabs()
    {
        if (prefabs.Count > 0) return;

        Transform prefabObject = transform.Find("Prefabs");

        foreach(Transform prefab in prefabObject)
        {
            prefabs.Add(prefab);
        }
        Debug.Log(transform.name + " Load prefabs: " + prefabs.Count);
        HidePrefab();
    }

    private void HidePrefab()
    {
        foreach (Transform prefab in prefabs)
        {
            prefab.gameObject.SetActive(false);
        }
    }

    public GameObject OnSpawn(GameObject prefabName ,Vector3 transform, Quaternion rotation)
    {
        GameObject newPrefab = Instantiate(prefabName, transform, rotation);
        return newPrefab;
    }


}
