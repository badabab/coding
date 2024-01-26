using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

// ���� ��Ʈ��
// ������ �ٷ� �� �����Ͱ� �����̴� ���� �帧(stream)���� ������ ��
// ������ �ٷ�� ���ؼ��� System.IO(Input/Output) ���ӽ����̽��� �ִ� FileStream Ŭ���� ���

public class TextFileStreamExample : MonoBehaviour
{    
    void Start()
    {
        // < ���� ���� >
        // �Ű�����
        // 1. � ����?        (������ ���)
        // 2. ��� �ٷ겨��?  (������ ���)
        FileStream fs = new FileStream("C:/Users/USER/Desktop/test.txt", FileMode.Create);
        // FileMode.Create: ������ ���ٸ� ���� ����, ������ ������.

        // < ���� ���� >
        // �ؽ�Ʈ ������ �� ���� "StreamWriter" Ŭ���� ���
        StreamWriter sw = new StreamWriter(fs);
        sw.WriteLine("�ȳ��ϼ���");
        sw.WriteLine("�� �̸��� �̼����Դϴ�.");
        sw.WriteLine("������ �ݰ�����.");
        sw.Close(); // ������ �� ���� �� �ݾ���� �Ѵ�.

        // < ���� �б� >
        fs = new FileStream("C:/Users/USER/Desktop/test.txt", FileMode.Open); // �ٽ� ����
        StreamReader sr = new StreamReader(fs);
        while (true)
        {
            string line = sr.ReadLine();
            if (line == null)
            {
                break;
            }
            Debug.Log(line);
        }
        sr.Close();
    }
}
