using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapGen : MonoBehaviour
{
    public struct Positions
    {
        public Vector3 positions;
        public bool used;
    };

    const int cantTrapsInGame = 10;
    const int cantTrapsTotal = 40;

    public Transform trap;
    Transform[] traps = new Transform[cantTrapsInGame];
    //const int cantTrapsInGame = 8;
    //const int cantTrapsTotal = 11;
    public Vector3[] auxPos = new Vector3[cantTrapsTotal];
    public Positions[] pos = new Positions[cantTrapsTotal];

    int aux;

    // Start is called before the first frame update
    void Start()
    {
        //for(int i=0;i<cantTrapsTotal; i++)
        //{
        //    pos[i].used = false;
        //    pos[i].positions = auxPos[i];
        //}

        //for(int i=0;i<cantTrapsInGame;i++)
        //{
        //    traps[i] = trap;
        //    Transform t = Instantiate(traps[i]);
        //    int p = Random.Range(0, cantTrapsTotal);
        //    if (pos[p].used)
        //    {
        //        while (pos[p].used)
        //        {
        //            p = Random.Range(0, cantTrapsTotal);
        //        }
        //    }
        //    t.transform.position = pos[p].positions;
        //    pos[p].used = true;
        //    if(p==4)
        //    {
        //        t.transform.Rotate(new Vector3(0, 0, 26.101f));
        //    }
        //    if(p>=9)
        //    {
        //        t.transform.Rotate(new Vector3(0, 0, 90.0f));
        //        t.transform.localScale = new Vector3(0.1822433f, 1, 0.2f);
        //    }

        //}

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
