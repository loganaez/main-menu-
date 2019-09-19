using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannondetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_IOS
        if (Input.phase == TouchPhase.Began)
        {
            timerIsGoing = true;
        }
        if (Touch.phase == TouchPhase.Ended)
        {
            if (timerIsGoing) Shoot();
        }

#endif


#if UNITY_EDITOR
        if (Input.GetMouseButtonDown(0))
        {
            timerIsGoing = true;
            if(Input.GetMouseButton(0)){
                if (timerIsGoing) Shoot();
            }
    }
}