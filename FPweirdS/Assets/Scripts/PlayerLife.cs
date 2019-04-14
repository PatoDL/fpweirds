using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    float vida;
    // Start is called before the first frame update
    void Start()
    {
        vida = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log(col.gameObject.name);
    }
}
