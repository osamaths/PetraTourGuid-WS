using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementAI : MonoBehaviour {
    public Transform player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        TrackPlayer();
	}

    void TrackPlayer()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(player.rotation.eulerAngles), 10 * Time.deltaTime);
    }
}
