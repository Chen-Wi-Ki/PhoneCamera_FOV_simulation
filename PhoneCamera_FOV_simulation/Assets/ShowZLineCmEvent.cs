using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowZLineCmEvent : MonoBehaviour
{
    public Transform Target;//�ؼЪ�
    public Text ShowText;
    LineRenderer _lineRenderer;
    void Start()
    {
        _lineRenderer = GetComponent<LineRenderer>();
        _lineRenderer.positionCount = 2; // ����I�������u��
        _lineRenderer.startWidth = 0.03f; // �u���_�l�e��
        _lineRenderer.endWidth = 0.03f; // �u�������e��
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
