using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SerializationExample : MonoBehaviour
{
    // ����ȭ(Serialization)
    // �޸𸮿� ����� ��ü�� ���Ͽ� �����ϱ� ���� ���·� �����ϴ� ��

    private void Start()
    {
        // �׽�Ʈ�� ��ü ����
        Human human = new Human();
        human.Name = "�̼���";
        human.Age = 25;
        
        // < ���� ���� >
        FileStream fs = new FileStream("C:/Users/USER/Desktop/test.txt", FileMode.Create);

        // < ���� ���� >
        // ��ü�� ���Ϸ� �� ���� "BinaryFormatter" Ŭ���� ���
        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(fs, human);
        fs.Close();

        // < ���� �б� >
        // ���Ϸκ��� ��ü�� �о� �� �� �Ȱ��� "BinaryFormatter" Ŭ������ ���
        fs = new FileStream("C:/Users/USER/Desktop/test.txt", FileMode.Open);
        Human h = bf.Deserialize(fs) as Human;
        if (h != null)
        {
            Debug.Log(h.Name);
            Debug.Log(h.Age);
        }
    }
    
}

[System.Serializable]
public class Human
{
    public string Name;
    public int Age;
}
