using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedManager : MonoBehaviour
{
    public float speedManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        ObjectMovement.ySpeed = speedManager;
    }
}
