using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class RotateLineRendererToOrigin : MonoBehaviour
{
    private LineRenderer lineRenderer;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        RotateLineToOrigin();
    }

    void RotateLineToOrigin()
    {
        Vector3 startPosition = transform.position; // �u�����_�I��m
        Vector3 endPosition = Vector3.zero; // ���I

        // �]�m Line Renderer ����ӳ��I
        lineRenderer.positionCount = 2;
        lineRenderer.SetPosition(0, startPosition);
        lineRenderer.SetPosition(1, endPosition);

        // �p����ਤ��
        Vector3 direction = new Vector3(0,60,0);
        Quaternion rotation = Quaternion.FromToRotation(Vector3.forward, direction);

        // �N Line Renderer �������I
        transform.rotation = rotation;
    }
}
