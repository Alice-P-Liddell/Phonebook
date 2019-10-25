using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserDataList
{
    public List<UserData> userDatas;
}

[System.Serializable]
public class UserData
{
    public UserData(string name)
    {
        this.name = name;
        //this.number = number;
        //this.email = email;
    }

    public string name;
    //public string number;
    //public string email;
}
