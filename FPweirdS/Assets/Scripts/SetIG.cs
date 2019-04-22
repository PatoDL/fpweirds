using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetIG : MonoBehaviour
{
    GameObject gm;

    void Start()
    {
        gm = GameObject.Find("GameManager");
    }

    public void setig()
    {
        gm.GetComponent<GameManager>().PlayAgain();
    }
}
