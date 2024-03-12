using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowYLineCmEvent : MonoBehaviour
{
    public Transform Target;//目標物
    public Text ShowText;
    LineRenderer _lineRenderer;
    void Start()
    {
        _lineRenderer = GetComponent<LineRenderer>();
        _lineRenderer.positionCount = 2; // 兩個點之間的線條
        _lineRenderer.startWidth = 0.05f; // 線條起始寬度
        _lineRenderer.endWidth = 0.05f; // 線條結束寬度
    }

    // Update is called once per frame
    void Update()
    {
        float Y_sum = (Target.position.y - transform.localPosition.y) * 100;
        _lineRenderer.SetPosition(0, transform.position);
        _lineRenderer.SetPosition(1, Target.position);
        ShowText.text = "" + Y_sum + " cm";
    }
}
