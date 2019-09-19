using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapDoubleTap : MonoBehaviour
{

    float tapTimer = 0f;
    public float doubleTapInterval = 0.2f;
    bool tapped = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        {
            if(tapped){
                tapTimer += Time.deltaTime;
                if(tapTimer > doubleTapInterval){
                    SingleTap();
                    tapped = false;
                }
            }
        }
        if (Input.anyKeyDown)
        {
            if(tapped){
                DoubleTap();
                tapped = false;
            } else{
                tapped = true;
            }
        }


    }

    void SingleTap(){
        Debug.Log("<color=red>Single Tap!</color>");
        Debug.Log("timer =" + tapTimer);
        tapTimer = 0;
        this.GetComponent<Renderer>().material.color = Random.ColorHSV();
    }

    void DoubleTap(){
        Debug.Log("<color=blue>double Tap!</color>");
        Debug.Log("timer =" + tapTimer);
        tapTimer = 0;
        transform.localScale += Vector3.one * 0.1f;
        if(this.transform.localScale.x > 5){
            this.transform.localScale = Vector3.one;
        }
    }
}
