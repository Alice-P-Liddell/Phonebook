using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

[System.Serializable]
public class SaveButton : MonoBehaviour
{
    List<UserData> data = new List<UserData>();
    public InputField inputFieldName;
    //public InputField inputFieldNumber;
    //public InputField inputFieldEmail;

    public string fieldTextName;
    //public string fieldTextNumber;
    //public string fieldTextemail;

    public Text tx;
    UserDataList userDataList = new UserDataList();

    private void Awake()
    {
        LoadUserData();
    }

    private void Save()
    {
        fieldTextName = inputFieldName.text;
        //fieldTextNumber = inputFieldNumber.text;
        //fieldTextemail = inputFieldEmail.text;

        data.Add(new UserData(fieldTextName));
        Debug.Log(data);
    }

    public void SaveUserData()
    {
        Save();

        UserDataList userDataList = new UserDataList();
        userDataList.userDatas = data;

        string userJData = JsonUtility.ToJson(userDataList);
        string path = Application.persistentDataPath + "/data.json";
        File.WriteAllText(path, userJData);

        Debug.Log("추가 완료");
        Debug.Log(path);
        print(userJData);
    }

    public void LoadUserData()
    {
        string userJData = File.ReadAllText(Application.persistentDataPath + "/data.json");
        tx.text = userJData;
    }
}

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

