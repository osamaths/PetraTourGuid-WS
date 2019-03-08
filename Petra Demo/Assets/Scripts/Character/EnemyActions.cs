using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyActions : MonoBehaviour {
    CharacterActions myActions;

    private void Start()
    {
        myActions = transform.GetComponent<CharacterActions>();
    }

    private void Update()
    {
        if (myActions.detectEnemy)
        {
            myActions.Attack();
        }
    }
}
