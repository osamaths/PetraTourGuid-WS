using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterActions : MonoBehaviour {
    public float ACTION_DELAY;
    public float attackDistance;
    public string targetTag;

    private bool actionDelay = true;
    HealthManager enemyHealthManager;
    private bool successAttack;
    internal bool detectEnemy;
    private string clickedBtn = "";

    Animator anim;
    
    // Use this for initialization
    void Start () {
        anim = transform.GetComponent<Animator>();
        enemyHealthManager = GameObject.FindWithTag(targetTag).GetComponent<HealthManager>();
	}
	
	// Update is called once per frame
	void Update () {
        CheckForEnemy();
	}

    void CheckForEnemy()
    {
        if (!actionDelay)
            return;

        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, attackDistance))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            if (hit.transform.tag == targetTag)
            {
                detectEnemy = true;
                if (targetTag == "Player")
                {
                    successAttack = true;
                } else
                {
                    if (clickedBtn == "attack")
                    {
                        successAttack = true;
                    }
                }
            }
        } else
        {
            successAttack = false;
            detectEnemy = false;
        }
    }

    IEnumerator waitActions()
    {
        actionDelay = false;
        yield return new WaitForSeconds(ACTION_DELAY);
        actionDelay = true;
    }
    void setAttack()
    {
        anim.SetBool("underAttack", false);
    }
    public void Attack()
    {
        if (!actionDelay)
            return;

        StartCoroutine(waitActions());
        anim.SetBool("isAttack", true);
        anim.SetBool("underAttack", true);

        Invoke("setAttack", 1f);

        //anim.SetBool("isAttack", false);
        print("Attack " + gameObject.name);
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
        if (!actionDelay)
            return;

        StartCoroutine(waitActions());
        anim.SetBool("isAvoid", true);

        print("Avoid " + gameObject.name);
        // play animation here
        // play voice here
    }
    void Die()
    {
        StartCoroutine(waitActions());
        transform.GetComponent<HealthManager>().isDead = true;
        print("Dead");
        // play animation here
        // play voice here
        // Disable all player inputs
    }
}
