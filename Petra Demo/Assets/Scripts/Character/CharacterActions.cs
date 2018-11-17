using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterActions : MonoBehaviour {
    public float ACTION_DELAY;
    public float attackDistance;
    public string targetTag;

    private float actionDelay = 0f;
    HealthManager enemyHealthManager;
    private bool successAttack;
    private string clickedBtn = "";

    // Use this for initialization
    void Start () {
        enemyHealthManager = GameObject.FindWithTag(targetTag).GetComponent<HealthManager>();
	}
	
	// Update is called once per frame
	void Update () {
        if (actionDelay > 0)
            actionDelay -= Time.deltaTime;

        CheckForEnemy();
	}

    void CheckForEnemy()
    {
        if (actionDelay != 0)
            return;

        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, attackDistance))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            if (hit.transform.tag == targetTag)
            {
                if (clickedBtn == "attack")
                {
                    successAttack = true;
                }
            } else if (successAttack)
            {
                successAttack = false;
            }
        }
    }

    public void Attack()
    {
        if (actionDelay != 0)
            return;

        actionDelay = ACTION_DELAY;
        print("Attack");
        if (successAttack)
        {
            successAttack = false;
            enemyHealthManager.MakeDamage(25);
        }
        // play animation here
        // play voice here
    }
    public void Avoid()
    {
        if (actionDelay != 0)
            return;

        actionDelay = ACTION_DELAY;
        print("Avoid");
        // play animation here
        // play voice here
    }
    void Die()
    {
        actionDelay = ACTION_DELAY;
        transform.GetComponent<HealthManager>().isDead = true;
        print("Dead");
        // play animation here
        // play voice here
        // Disable all player inputs
    }
}
