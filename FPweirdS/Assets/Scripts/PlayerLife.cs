using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    public GameObject player;
    public float vida;
    public float force;
    Rigidbody rig;
    Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        vida = 100;
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5)
        {
            vida = 0;
        }
        if (vida<=0)
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().SetGO(true);
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name=="TrapCol")
        {
            vida -= 50;
            direction = -(new Vector3(player.transform.position.x, 0, player.transform.position.z) - new Vector3(col.gameObject.transform.position.x, 0, col.gameObject.transform.position.z));
            rig.AddForce(transform.position - direction * force,ForceMode.Impulse);
            Debug.Log("life: " + vida);
        }
    }
}
