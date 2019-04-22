using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateHealthText : MonoBehaviour
{
    public Text healthText;
    GameObject player;

    void Start()
    {
        player = GameObject.Find("RigidBodyFPSController");
        updateHealthText();
    }

    void Update()
    {
        updateHealthText();
    }

    void updateHealthText()
    {
        healthText.text = "Health: " + player.GetComponent<PlayerLife>().vida;
    }
}
