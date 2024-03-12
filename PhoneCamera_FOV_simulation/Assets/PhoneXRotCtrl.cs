using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhoneXRotCtrl : MonoBehaviour
{
    public GameObject PhoneObj;
    public float X_Angle;
    private void Start()
    {
        PhoneObj = GameObject.Find("phone512");
    }

    public void XRotCtrlEvent()
    {
        X_Angle = (GetComponent<Scrollbar>().value - 0.5f) * 60;
        PhoneObj.transform.rotation = Quaternion.Euler(X_Angle,0,180);
    }
}
