using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapCollision : MonoBehaviour
{
    public bool Collided = false;
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        //Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name != "RigidBodyFPSController" && (collision.gameObject.name=="Piso" || collision.gameObject.tag == "Plantilla"))
        {
            Debug.Log(collision.gameObject.tag);
            Collided = true;
            GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}
