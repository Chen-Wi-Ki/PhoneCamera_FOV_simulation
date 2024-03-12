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
        Vector3 startPosition = transform.position; // 線條的起點位置
        Vector3 endPosition = Vector3.zero; // 原點

        // 設置 Line Renderer 的兩個頂點
        lineRenderer.positionCount = 2;
        lineRenderer.SetPosition(0, startPosition);
        lineRenderer.SetPosition(1, endPosition);

        // 計算旋轉角度
        Vector3 direction = new Vector3(0,60,0);
        Quaternion rotation = Quaternion.FromToRotation(Vector3.forward, direction);

        // 將 Line Renderer 旋轉到原點
        transform.rotation = rotation;
    }
}
