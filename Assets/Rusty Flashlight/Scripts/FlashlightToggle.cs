using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class FlashlightToggle : MonoBehaviour
{
    public GameObject lightGO;
    public GameObject flashlight; //light gameObject to work with
    public bool isOn = false; //is flashlight on or off?
    public Material flashlightOn, flashlightOff,diffuse;
    public AudioSource foley_on, foley_off;



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
              Material[] materialsArray = flashlight.GetComponent<MeshRenderer>().materials;
              materialsArray[0] = flashlightOn;
              materialsArray[1] = flashlightOn;
              materialsArray[2] = diffuse;
              flashlight.GetComponent<Renderer>().materials = materialsArray;
              foley_on.Play();

            }
          //turn light off
          else
          {
              lightGO.SetActive(false);
              Material[] materialsArray = flashlight.GetComponent<Renderer>().materials;
              materialsArray[0] = flashlightOff;
              materialsArray[1] = flashlightOff;
              materialsArray[2] = diffuse;
              flashlight.GetComponent<Renderer>().materials = materialsArray;
              foley_off.Play();
            }
    }
}