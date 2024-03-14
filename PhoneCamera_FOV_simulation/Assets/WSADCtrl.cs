using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WSADCtrl : MonoBehaviour
{
    float TempY, TempZ;
    public GameObject[] TextObj;
    // Update is called once per frame
    void Update()
    {
        TempY = transform.rotation.eulerAngles.y + Input.GetAxis("Horizontal");
        TempZ = transform.rotation.eulerAngles.z + Input.GetAxis("Vertical");

        transform.rotation = Quaternion.Euler(0, TempY, TempZ);

        for (int i = 0; i < TextObj.Length; i++)
        {
            TextObj[i].GetComponent<RectTransform>().rotation = Quaternion.Euler(0, TempY+90, 0);
        }
    }
}
