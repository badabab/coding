using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class BinaryFileStreamExample : MonoBehaviour
{
    void Start()
    {
        // < 파일 열기 >
        FileStream fs = new FileStream("C:/Users/USER/Desktop/test.txt", FileMode.Create);
        // .dat : 데이터(data)의 약어로 사용자가 정의한 데이터가 들어있는 파일의 확장자

        // < 파일 쓰기 >
        // 바이너리 파일을 쓸 때는 "BinaryWriter" 클래스 사용
        BinaryWriter bw = new BinaryWriter(fs);
        //bw.Write("Hello");  // 05 72 101 108 108 111
        bw.Write(593);      // 100 1010001
        // 5: 101  9: 1001  3: 011
        bw.Close();

        // 장점: 컴퓨터는 데이터를 0과 1 같은 바이너리 형태로 처리하므로
        // Binary를 사용하면 메모리를 좀 더 효율적으로 사용하고, 속도도 더 빠르다.

        // < 파일 읽기 >
        // 바이너리 파일을 읽을 때는 "BinaryReader" 클래스 사용
        fs = new FileStream("C:/Users/USER/Desktop/test.txt", FileMode.Open);
        BinaryReader br = new BinaryReader(fs);
        // Debug.Log(br.Read()); // 5 : 문자열의 길이
        // Debug.Log(br.Read()); // 72 : H의 아스키코드 값
        Debug.Log(br.ReadString());
        Debug.Log(br.ReadInt32());
        br.Close();
    }
}
