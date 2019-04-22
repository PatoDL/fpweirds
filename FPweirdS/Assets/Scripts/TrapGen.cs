using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapGen : MonoBehaviour
{
    const int cantTrapsInGame = 10;
    const int cantTrapsTotal = 40;

    public Transform trap;
    Transform[] traps = new Transform[cantTrapsInGame];
    int aux;

    // Start is called before the first frame update
    void Start()
    {
        aux = (int)GameObject.Find("WorldGen").GetComponent<WorldGenerator>().Width;

        for (int i=0;i<cantTrapsInGame;i++)
        {
            traps[i] = trap;
        }

       
        for(int j=0;j<cantTrapsInGame;j++)
        {
            Instantiate(traps[j]);
            traps[j].position = new Vector3(Random.Range(0,(20*aux)),20,Random.Range(0,(20*aux)));
        }
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
