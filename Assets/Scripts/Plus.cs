using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

[System.Serializable]
public class Plus : MonoBehaviour
{

    List<UserData> data = new List<UserData>();
    public InputField inputFieldName;
    public InputField inputFieldNumber;
    public InputField inputFieldEmail;

    public string fieldTextName;
    public string fieldTextNumber;
    public string fieldTextemail;



    private void Save()
    {
        fieldTextName = inputFieldName.text;
        fieldTextNumber = inputFieldNumber.text;
        fieldTextemail = inputFieldEmail.text;
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
        print(userJData);
    }

    public void LoadUserData()
    {

    }

}

public class UserDataList
{
    public List<UserData> userDatas;
}

[System.Serializable]
public class UserData

{
    public UserData(string name, int number, string email)
    {
        this.name = name;
        this.number = number;
        this.email = email;
    }

    public string name;
    public int number;
    public string email;

}

