using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonList
{
    public List<Person> personList;
}

[System.Serializable]       //Person타입 안에 있는 것들을 직렬화해서 StreamWriter할 수 있게 만들어준다.
public class Person
{
    public string name;
    public string phoneNumber;
    public string email;

    public Person(string name, string phoneNumber, string email)
    {
        this.name = name;
        this.phoneNumber = phoneNumber;
        this.email = email;
    }
}
