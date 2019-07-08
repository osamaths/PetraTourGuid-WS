using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARController : MonoBehaviour
{
    public GameObject camera;
    public GameObject targets;
    bool isActiveAR = false;
    bool isActiveSound=false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void TrigerAR()
    {
        isActiveAR = !isActiveAR;
        print("true");
        ActiveAR();
    }


    public void TrigerSound()
    {
        isActiveSound = !isActiveSound;
        ActiveSound();
}


    void ActiveAR()
    {
        if (isActiveAR)
        {
            print(isActiveAR);
            camera.active = true;
            targets.active = true;
        }
        else
        {
            camera.active = false;
            targets.active = false;

        }
    }

    void ActiveSound()
    {
        if (isActiveSound)
        {
          
            print("isActiveSound" + isActiveSound);
            transform.GetComponent<Model_>().playAudio();
        }
        else
        {
            transform.GetComponent<Model_>().stopPlaying();

        }
    }
    
}
