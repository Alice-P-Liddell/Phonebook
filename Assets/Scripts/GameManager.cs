using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;                                                         //파일 저장을 구현하기 위해 필요한 네임스페이스. IO는 인풋아웃풋의 약자.

public class GameManager : MonoBehaviour                                 //XML과 JSON은 둘다 파싱을 위한 파일 형태이며, 요즘은 제이슨이 더 많이 쓰인다.
{                                                                        //유니티에서는 제이슨의 모든 기능을 전부 지원하지는 않고 JsonUtility를 통해 일부 기능만 지원한다.
    void Start()
    {
        Person person1 = new Person("홍길동", "010-5555-5555", "test@gmail.com");
        Person person2 = new Person("김길동", "010-5555-5555", "test@gmail.com");
        Person person3 = new Person("왕길동", "010-5555-5555", "test@gmail.com");

        List<Person> pList = new List<Person>();
        pList.Add(person1);
        pList.Add(person2);
        pList.Add(person3);

        PersonList personList = new PersonList();
        personList.personList = pList;

        string jsonStr = JsonUtility.ToJson(person1);

        string path1 = "Assets\\data.txt";                              //\는 혹은 백슬래쉬는 스트링 안이라고 해도 사용할 수 없다. 폴더 위치를 넣기 위해서는 두개 넣어주면 된다.
        string path2 = $"{Application.persistentDataPath}\\data.txt";

        StreamWriter streamWriter = new StreamWriter(path2);            //스트림라이트를 쓸 때에는 Path를 인자로 넣어줘야 한다.(파일 위치와 이름)

        streamWriter.WriteLine(jsonStr);
        streamWriter.Close();                                           //StreamWriter타입변수.Close() : 저장하고 닫기
                                                                        //StreamWriter타입변수.Flush() : 저장
    }

    void Update()
    {
        
    }
}
