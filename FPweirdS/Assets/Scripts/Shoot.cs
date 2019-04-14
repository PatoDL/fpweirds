using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float rayDistance = 5;
    public LayerMask rayCastLayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.parent.position, transform.parent.forward, out hit, rayDistance, rayCastLayer))
        {
            string layerHitted = LayerMask.LayerToName(hit.transform.gameObject.layer);

            if (layerHitted == "Trap")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    hit.transform.gameObject.GetComponentInParent<TrapDestroy>().destroyed = true;
                }
            }
        }
        Debug.DrawRay(transform.parent.position,transform.parent.forward*rayDistance, Color.red);
    }
}
