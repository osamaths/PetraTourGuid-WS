using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelsController : MonoBehaviour
{
    public GameObject models;
    float y;//= models.transform.rotation.y;
    float x;
    float z;
    float w;

    // Start is called before the first frame update
    void Start()
    {
       y = models.transform.rotation.y;
       x= models.transform.rotation.x;
       z= models.transform.rotation.z;
       w= models.transform.rotation.w;
    }

    // Update is called once per frame
    void Update()
    {
        y += 10*Time.deltaTime;
        models.transform.Rotate( Vector3.left    *50 * Time.deltaTime);//=  Quaternion.Euler(0, 0, y);


    }
}
