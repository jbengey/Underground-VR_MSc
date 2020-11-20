using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class FlashlightToggle : MonoBehaviour
{
    public GameObject lightGO;
    public MeshRenderer flashlight; //light gameObject to work with
    public bool isOn = false; //is flashlight on or off?
    public Material flashlightOn, flashlightOff;

    Material[] m = new Material[3];

    // Use this for initialization
    void Start()
    {
        //set default off
        lightGO.SetActive(isOn);
    }

    //toggle flashlight
    public void togglelight()
    {
          //toggle light
          isOn = !isOn;
          //turn light on
          if (isOn)
          {
          lightGO.SetActive(true);
            m = flashlight.materials;
            m[1] = new Material(flashlightOn); 
            m[2] = new Material(flashlightOn);
          }
          //turn light off
          else
          {
          lightGO.SetActive(false);
            m = flashlight.materials;
            m[1] = new Material(flashlightOff);
            m[2] = new Material(flashlightOff);
        }
    }
}