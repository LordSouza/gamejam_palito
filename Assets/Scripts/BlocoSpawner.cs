using System.Collections.Generic;
using UnityEngine;

public class BlocoSpawner : MonoBehaviour
{
    [SerializeField] int quantityBlocos = 8;
    [SerializeField] private List<GameObject> blocksPrefabs;

    private void Awake()
    {
        for (int y = 0; y < blocksPrefabs.Count; y++)
        {
            
            for (int i = 0; i < quantityBlocos; i++)
            {
                Vector3 offset = new Vector3(i*2, y, 0);
                Instantiate(blocksPrefabs[y], transform.position + offset, Quaternion.identity);
            }
        }
    }

}