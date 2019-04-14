using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    public GameObject player;
    float vida;
    public float force;
    Rigidbody rig;
    // Start is called before the first frame update
    void Start()
    {
        vida = 100;
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Trap")
        {
            vida -= 50;
            rig.AddForce(Vector3.back * force);
            Debug.Log("life: " + vida);
        }
    }
}
