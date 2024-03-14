using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraViewField : MonoBehaviour
{
    LineRenderer[] _lineRenderer;
    public GameObject[] ChangeSphereObj;
    public GameObject phoneObj, FoVTextObj;
    Vector3 temp_pos;
    float r = 3, xx, yy;

    Vector3 direction;
    Quaternion rotation;

    public float ViewField_Value1, ViewField_Value2;

    // Start is called before the first frame update
    void Start()
    {
        _lineRenderer = new LineRenderer[2];
        _lineRenderer[0] = GameObject.Find("LineRenderer0").GetComponent<LineRenderer>();
        _lineRenderer[0].positionCount = 2; // 兩個點之間的線條
        _lineRenderer[0].startWidth = 0.02f; // 線條起始寬度
        _lineRenderer[0].endWidth = 0.02f; // 線條結束寬度

        _lineRenderer[1] = GameObject.Find("LineRenderer1").GetComponent<LineRenderer>();
        _lineRenderer[1].positionCount = 2; // 兩個點之間的線條
        _lineRenderer[1].startWidth = 0.02f; // 線條起始寬度
        _lineRenderer[1].endWidth = 0.02f; // 線條結束寬度
        
        
    }

    // Update is called once per frame
    void Update()
    {
        /*//旋轉角計算法
        ViewField_Value = GetComponent<Camera>().fieldOfView;//0.5625f;
        xx = Mathf.Cos(ViewField_Value) * r;
        yy = Mathf.Sin(ViewField_Value) * r;
        _lineRenderer[0].positionCount = 2; // 兩個點之間的線條
        _lineRenderer[0].startWidth = 0.01f; // 線條起始寬度
        _lineRenderer[0].endWidth = 0.01f; // 線條結束寬度
        _lineRenderer[0].SetPosition(0, transform.position);
        temp_pos = transform.position + new Vector3(0, xx, yy);
        _lineRenderer[0].SetPosition(1, temp_pos);

        
        _lineRenderer[1].positionCount = 2; // 兩個點之間的線條
        _lineRenderer[1].startWidth = 0.01f; // 線條起始寬度
        _lineRenderer[1].endWidth = 0.01f; // 線條結束寬度
        _lineRenderer[1].SetPosition(0, transform.position);
        temp_pos = transform.position + new Vector3(0, -xx, yy);
        _lineRenderer[1].SetPosition(1, temp_pos);
        */

        //直線定位後旋轉
        ViewField_Value1 = (GetComponent<Camera>().fieldOfView / 2) + phoneObj.transform.rotation.eulerAngles.x;
        ViewField_Value2 = -(GetComponent<Camera>().fieldOfView / 2) + phoneObj.transform.rotation.eulerAngles.x;
        _lineRenderer[0].transform.rotation = Quaternion.Euler(new Vector3(ViewField_Value1 , 0,0));
        _lineRenderer[0].SetPosition(0, transform.position);
        _lineRenderer[0].SetPosition(1, ChangeSphereObj[0].transform.position);

        _lineRenderer[1].transform.rotation = Quaternion.Euler(new Vector3(ViewField_Value2, 0, 0));
        _lineRenderer[1].SetPosition(0, transform.position);
        _lineRenderer[1].SetPosition(1, ChangeSphereObj[1].transform.position);

        FoVTextObj.GetComponent<Text>().text = "" + GetComponent<Camera>().fieldOfView + "°";
    }
}
