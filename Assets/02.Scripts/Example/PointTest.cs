using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ����ü�� new Ű���带 ������� �ʾƵ� ������ ����/�Ҵ� �� �� �ִ�.
        // ��� ���� ��� �Ӽ�(����)�� �ʱ�ȭ ����� ����� �� �ִ�.
        Point point1;
        point1.X = 3;
        point1.Y = 7;
        Debug.Log($"x: {point1.X}, y: {point1.Y}");

        Point point2 = new Point(4, 5);
        Debug.Log($"x: {point2.X}, y: {point2.Y}");

        point2 = point1;
        point1 = point2;
        point2.X = 16;
        
        Debug.Log("---- ���� �� ----");
        Debug.Log($"x: {point1.X}, y: {point1.Y}");
        Debug.Log($"x: {point2.X}, y: {point2.Y}");
    }
}
