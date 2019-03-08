using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed;
    public float rotSpeed;

    public Animator anim;

    private void Start()
    {
        anim = transform.GetComponent<Animator>();
    }

    public void MoveSide(float value)
    {
        if (transform.GetComponent<HealthManager>().isDead) return;

        transform.Translate(value * ( speed * 0.0001f ), 0, 0);

        anim.SetFloat("horizontal", value);
    }
    public void MoveForawrd(float value)
    {
        if (transform.GetComponent<HealthManager>().isDead) return;

        transform.Translate(0, 0, value * (speed * 0.0001f));
        anim.SetFloat("speed", value);

    }
    public void Rotate (float value)
    {
        if (transform.GetComponent<HealthManager>().isDead) return;

        transform.Rotate(0, value * (rotSpeed * 0.005f), 0);
    }
}
