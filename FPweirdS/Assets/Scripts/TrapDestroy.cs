using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDestroy : MonoBehaviour
{
    public bool destroyed;
    // Start is called before the first frame update
    void Start()
    {
        destroyed = false;
    }

    // Update is called once per frame
    void Update()
    {
       if(destroyed)
        {
          Destroy(this.gameObject);
        }
    }
}
