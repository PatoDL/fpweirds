using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenerator : MonoBehaviour
{
    public GameObject[] PlantillasPF = new GameObject[3];
    public GameObject[] Plantillas = new GameObject[3];
    public float Height = 3, Width = 3;
    void Start()
    {
        Generate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Generate()
    {
        for (int i = 0; i < Width; i++)
        {
            for (int j = 0; j < Height; j++)
            {
                Plantillas[j] = Instantiate(PlantillasPF[Random.Range(0, 3)]);
                Plantillas[j].transform.position = new Vector3(20 * i, 1, 20 * j);
            }
        }
    }
}
