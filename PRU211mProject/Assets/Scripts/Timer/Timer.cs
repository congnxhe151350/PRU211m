using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public bool isRunning;
    public bool isFinish;
    public float elapseTime;
    public float arlarmTime;
    public float arlarmTime2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        arlarmTime2 = Time.time;
        elapseTime += Time.deltaTime;
        if (elapseTime >= arlarmTime)
        {
            isFinish = true;
        }
    }

    public void StartTime()
    {
        isRunning = true;
        isFinish = false;
        elapseTime = 0;
    }
}
