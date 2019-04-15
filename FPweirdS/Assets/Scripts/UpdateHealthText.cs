using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateHealthText : MonoBehaviour
{
    public Text healthText;

    void Start()
    {
        updateHealthText();
    }

    void Update()
    {
        updateHealthText();
    }

    void updateHealthText()
    {
        healthText.text = "Health: " + GameObject.Find("RigidBodyFPSController").GetComponent<PlayerLife>().vida;
    }
}
