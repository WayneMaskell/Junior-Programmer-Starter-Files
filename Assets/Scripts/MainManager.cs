using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;
    public Color teamColor;
    private void Awake()
    {
        if (Instance != null) 
        { Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadColor();
    }
    // Start is called before the first frame update
    void Start()
    {
        
        

       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SaveColor() 
    {
        SaveData data = new SaveData();
        data.teamcolor = teamColor;
        Debug.Log("something saved");

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/saveFile.json",json);
    }
    public void LoadColor() 
    {
        string path = Application.persistentDataPath + "/saveFile.json";
        if (File.Exists(path)) 
        {
            string json = File.ReadAllText(path);   

            SaveData data = JsonUtility.FromJson<SaveData>(json);
            teamColor = data.teamcolor;
        }
    }
}
[System.Serializable]
class SaveData 
{
    public Color teamcolor;
}
