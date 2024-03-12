using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhoneYPosCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PhoneObj;
    public float Y_Height;
    private void Start()
    {
        PhoneObj = GameObject.Find("phone512");
    }

    public void YPosCtrlEvent()
    {
        Y_Height = (GetComponent<Scrollbar>().value+0.1f)*1.5f;
        PhoneObj.transform.position = new Vector3(0,Y_Height,0);
    }
}
