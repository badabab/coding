using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class BinaryFileStreamExample : MonoBehaviour
{
    void Start()
    {
        // < ���� ���� >
        FileStream fs = new FileStream("C:/Users/USER/Desktop/test.txt", FileMode.Create);
        // .dat : ������(data)�� ���� ����ڰ� ������ �����Ͱ� ����ִ� ������ Ȯ����

        // < ���� ���� >
        // ���̳ʸ� ������ �� ���� "BinaryWriter" Ŭ���� ���
        BinaryWriter bw = new BinaryWriter(fs);
        //bw.Write("Hello");  // 05 72 101 108 108 111
        bw.Write(593);      // 100 1010001
        // 5: 101  9: 1001  3: 011
        bw.Close();

        // ����: ��ǻ�ʹ� �����͸� 0�� 1 ���� ���̳ʸ� ���·� ó���ϹǷ�
        // Binary�� ����ϸ� �޸𸮸� �� �� ȿ�������� ����ϰ�, �ӵ��� �� ������.

        // < ���� �б� >
        // ���̳ʸ� ������ ���� ���� "BinaryReader" Ŭ���� ���
        fs = new FileStream("C:/Users/USER/Desktop/test.txt", FileMode.Open);
        BinaryReader br = new BinaryReader(fs);
        // Debug.Log(br.Read()); // 5 : ���ڿ��� ����
        // Debug.Log(br.Read()); // 72 : H�� �ƽ�Ű�ڵ� ��
        Debug.Log(br.ReadString());
        Debug.Log(br.ReadInt32());
        br.Close();
    }
}
