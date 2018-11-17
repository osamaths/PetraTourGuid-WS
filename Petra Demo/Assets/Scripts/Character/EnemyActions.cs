using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyActions : MonoBehaviour {
    public float attackDistance;

    public float ACTION_DELAY;
    public float DELAY_RATE;
    float actionDelay = 0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        CheckForPlayer();
        if (actionDelay > 0)
            actionDelay -= Time.deltaTime * DELAY_RATE;
    }

    void CheckForPlayer()
    {
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, attackDistance  ))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            if (hit.transform.tag == "Player")
            {
                MakeAction();
            }
            Debug.Log("Did Hit");
        }
    }

    void MakeAction()
    {
        if (actionDelay != 0)
            return;
    }

    void Attack()
    {
        actionDelay = ACTION_DELAY;
        print("Attack");
    }
    void Defence()
    {
        actionDelay = ACTION_DELAY;
        print("Defence");
    }
    void Die()
    {
        actionDelay = ACTION_DELAY;
        print("Dead");
    }
}
