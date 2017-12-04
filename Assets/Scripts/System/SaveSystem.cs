using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSystem : MonoBehaviour {
    

    public void InitializeSaveSystem()
    {
        GetData();
    }

    public void GetData()
    {
        string _saveFile = PlayerPrefs.GetString("Save", "");

        if (_saveFile == "")
        {
            GameManager.instance.saveFile = new SaveFile();
        }
        else
        {
            GameManager.instance.saveFile = JsonUtility.FromJson<SaveFile>(_saveFile);
        }
    }

    public void SaveData()
    {
        string _saveFile;
        _saveFile = JsonUtility.ToJson(GameManager.instance.saveFile);

        PlayerPrefs.SetString("Save",_saveFile);

    }


    void OnApplicationQuit()
    {
        SaveData();
    }

}
