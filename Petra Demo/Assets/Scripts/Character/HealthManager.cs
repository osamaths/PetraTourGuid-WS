using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour {
    public float health { set; get; }
    public TextMesh healthBar;
    public bool isDead { set; get; }

    private void Start()
    {
        healthBar.text = "100pt";
        healthBar.color = Color.green;

        health = 100;
    }

    public void MakeDamage(float value)
    {
        health -= value;
        SetHealthToTextMesh();
    }

    public void IncreaseHealth(float value)
    {
        health += value;
        SetHealthToTextMesh();
    }

    public void SetHealthToTextMesh()
    {
        healthBar.text = health.ToString() + "pt";
        if (health <= 25)
            healthBar.color = Color.red;
        else
            healthBar.color = Color.green;
    }
}
