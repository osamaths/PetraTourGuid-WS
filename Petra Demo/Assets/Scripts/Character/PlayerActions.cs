using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour {
    public float ACTION_DELAY;
    public float DELAY_RATE;
    float actionDelay = 0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (actionDelay > 0)
            actionDelay -= Time.deltaTime * DELAY_RATE;
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
    void Avoid()
    {
        actionDelay = ACTION_DELAY;
        print("Avoid");
    }
    void Die()
    {
        actionDelay = ACTION_DELAY;
        print("Dead");
    }
}
