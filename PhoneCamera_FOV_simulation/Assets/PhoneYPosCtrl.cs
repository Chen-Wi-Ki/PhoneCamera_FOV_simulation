using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhoneYPosCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject PhoneObj;
    InputField _InputField;
    float Y_Height;
    private void Start()
    {
        PhoneObj = GameObject.Find("phone512");
        _InputField = GameObject.Find("PhoneYPosCtrl-InputField").GetComponent<InputField>();
    }

    public void YPosCtrlEvent()
    {
        Y_Height = (GetComponent<Scrollbar>().value+0.1f)*1.5f;
        PhoneObj.transform.position = new Vector3(0,Y_Height,0);
        _InputField.text = "" + Y_Height*100;
    }

    public void YPosInputEvent()
    {
        Y_Height = float.Parse(_InputField.text);
        PhoneObj.transform.position = new Vector3(0, Y_Height/100, 0);
    }
}
