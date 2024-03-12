using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowZLineCmEvent : MonoBehaviour
{
    public Transform Target;//目標物
    public Text ShowText;
    LineRenderer _lineRenderer;
    void Start()
    {
        _lineRenderer = GetComponent<LineRenderer>();
        _lineRenderer.positionCount = 2; // 兩個點之間的線條
        _lineRenderer.startWidth = 0.03f; // 線條起始寬度
        _lineRenderer.endWidth = 0.03f; // 線條結束寬度
    }

    // Update is called once per frame
    void Update()
    {
        float Z_sum = (Target.position.z - transform.localPosition.z) * 100;
        _lineRenderer.SetPosition(0, transform.position);
        _lineRenderer.SetPosition(1, Target.position);
        ShowText.text = "" + Z_sum + " cm";

    }
}
