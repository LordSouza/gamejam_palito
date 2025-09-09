using System.Collections.Generic;
using UnityEngine;

public class BlocoController : MonoBehaviour
{
    [SerializeField] int quantityBlocos = 5;
    [SerializeField] private List<GameObject> blocksPrefabs;

    private void Awake()
    {
        for (int y = 0; y < quantityBlocos; y++)
        {
            
            for (int i = 0; i < quantityBlocos; i++)
            {
                int x = Screen.width / (quantityBlocos + 2) * i;
                Vector3 offset = new Vector3(x, y, 0);
                Instantiate(blocksPrefabs[y], transform.position + offset, Quaternion.identity);
            }
        }
    }
}