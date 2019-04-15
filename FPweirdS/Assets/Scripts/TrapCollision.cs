using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapCollision : MonoBehaviour
{
    public bool Collided = false;
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.name != "RigidBodyFPSController" && collision.gameObject.name == "Piso")
        {
            Collided = true;
        }
    }
}
