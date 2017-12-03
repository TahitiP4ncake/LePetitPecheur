using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSystem : MonoBehaviour {
    
    [Header("Managers")]
    public GameManager gameManager;

    public void InitializeSaveSystem()
    {
        GetData();
    }

    public void GetData()
    {
        string _saveFile = PlayerPrefs.GetString("Save", "");

        if (_saveFile == "")
        {
            gameManager.saveFile = new SaveFile();
        }
        else
        {
            gameManager.saveFile = JsonUtility.FromJson<SaveFile>(_saveFile);
        }
    }

    public void SaveData()
    {
        string _saveFile;
        _saveFile = JsonUtility.ToJson(gameManager.saveFile);

        PlayerPrefs.SetString("Save",_saveFile);

    }


    void OnApplicationQuit()
    {
        SaveData();
    }

}
