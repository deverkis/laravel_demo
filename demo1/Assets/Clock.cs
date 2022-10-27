using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Clock : MonoBehaviour
{
    public Transform hoursTransform;
    public Transform minutesTransform;
    public Transform secondsTransform;
    public bool continuous;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(continuous){
            UpdateContinucus();
        }else{
            UpdateDiscrete();
        }
    }

    const float degreePerMinute = 6f;
    const float degreePerSecond = 6f;
    const float degreePerHour = 30f;

    void Awake() {
        DateTime time = DateTime.Now;
        hoursTransform.localRotation = Quaternion.Euler(0f,time.Hour * degreePerHour,0f);
        minutesTransform.localRotation = Quaternion.Euler(0f,time.Minute * degreePerMinute,0f);
        secondsTransform.localRotation = Quaternion.Euler(0f,time.Second * degreePerSecond,0f);
    }

    void UpdateContinucus(){
        DateTime time = DateTime.Now;
        hoursTransform.localRotation = Quaternion.Euler(0f,time.Hour * degreePerHour,0f);
        minutesTransform.localRotation = Quaternion.Euler(0f,time.Minute * degreePerMinute,0f);
        secondsTransform.localRotation = Quaternion.Euler(0f,time.Second * degreePerSecond,0f);
    }

    void UpdateDiscrete(){
        DateTime time = DateTime.Now;
        hoursTransform.localRotation = Quaternion.Euler(0f,time.Hour * degreePerHour,0f);
        minutesTransform.localRotation = Quaternion.Euler(0f,time.Minute * degreePerMinute,0f);
        secondsTransform.localRotation = Quaternion.Euler(0f,time.Second * degreePerSecond,0f);
    }
}
