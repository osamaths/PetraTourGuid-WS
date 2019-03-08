using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoysticInfo : MonoBehaviour {

    public string name { set; get; }

    private void Start()
    {
        name = gameObject.name;
    }
    
}
