using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Camera1FoVCtrl : MonoBehaviour
{
    GameObject Camera1Obj;
    InputField _InputField;
    float FoV_value;
    private void Start()
    {
        Camera1Obj = GameObject.Find("Main Camera 1");
        _InputField = GameObject.Find("PhoneFoVCtrl-InputField").GetComponent<InputField>();
    }

    public void FoVCtrlEvent()
    {
        FoV_value = (GetComponent<Scrollbar>().value) * 150+30;
        Camera1Obj.GetComponent<Camera>().fieldOfView = FoV_value;
        _InputField.text = "" + FoV_value;
    }

    public void FoVInputEvent()
    {
        FoV_value = float.Parse(_InputField.text);
        if (FoV_value > 180)
        {
            FoV_value = 180;
        }
        else if (FoV_value < 30)
        {
            FoV_value = 30;
        }
        Camera1Obj.GetComponent<Camera>().fieldOfView = FoV_value;
    }
}
