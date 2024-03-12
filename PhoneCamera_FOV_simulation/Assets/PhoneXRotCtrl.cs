using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhoneXRotCtrl : MonoBehaviour
{
    GameObject PhoneObj;
    InputField _InputField;
    float X_Angle;
    private void Start()
    {
        PhoneObj = GameObject.Find("phone512");
        _InputField = GameObject.Find("PhoneXRotCtrl-InputField").GetComponent<InputField>();
    }

    public void XRotCtrlEvent()
    {
        X_Angle = (GetComponent<Scrollbar>().value - 0.5f) * 60;
        PhoneObj.transform.rotation = Quaternion.Euler(X_Angle,0,180);
        _InputField.text = ""+X_Angle;
    }

    public void XRotInputEvent()
    {
        X_Angle = float.Parse(_InputField.text);
        if (X_Angle > 30)
        {
            X_Angle = 30;
        }
        else if (X_Angle<-30)
        {
            X_Angle = -30;
        }
        PhoneObj.transform.rotation = Quaternion.Euler(X_Angle, 0, 180);
    }
}
