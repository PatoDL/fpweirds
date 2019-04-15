using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetIG : MonoBehaviour
{
    public void setig()
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().PlayAgain();
    }
}
