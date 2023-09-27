using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Apple;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstacle;
    private long pastFrame;

    // Start is called before the first frame update
    void Start()
    {
        pastFrame = Time.frameCount;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount - pastFrame == 50)
        {
            Instantiate(obstacle, gameObject.transform); 
            pastFrame = Time.frameCount;
        }
    }
}
