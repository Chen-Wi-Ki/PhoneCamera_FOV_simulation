using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HumanZPosCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject PhoneObj;
    InputField _InputField;
    float Z_Width;
    private void Start()
    {
        PhoneObj = GameObject.Find("Human");
        _InputField = GameObject.Find("HumanZPosCtrl-InputField").GetComponent<InputField>();
    }

    public void ZPosCtrlEvent()
    {
        Z_Width = (GetComponent<Scrollbar>().value + 0.1f) * 5f;
        PhoneObj.transform.position = new Vector3(0, 0, Z_Width);
        _InputField.text = "" + (Z_Width * 100);
    }

    public void ZPosInputEvent()
    {
        Z_Width = float.Parse(_InputField.text);
        if (Z_Width > 550)
        {
            Z_Width = 550;
        }
        else if (Z_Width < 50)
        {
            Z_Width = 50;
        }
        PhoneObj.transform.position = new Vector3(0, 0, Z_Width/100);
    }
}
