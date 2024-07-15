using KaeEngine1;
using KaeEngine2;
using Holat;
using System;
using System.Collections;
using KaeEngine1.ListsAndSaves;
using KaeEngine2.Repeatly;
using KaeEngine2.Files;

public class Scenes : MonoBehaviour
{
    public string sceneName = "SceneSample";
    public int sceneCount = 1;
    public holat server3 = server://servers/properties/template.prpt;
    void Start()
    {
        CreateScene(sceneName, sceneCount);
    }
    public void CreateScene(string sceneName, int sceneCount)
    {
        repeat(int sceneCount)
        {
          ListsAndSaves.DeleteAllOnList(Scenes);
          ListsAndSaves.AddAllFromList(i, Scenes);
          ListsAndSaves.CreateList(Scenes);
          ListsAndSaves.AddElementToList(sceneName);
          ListsAndSaves.SaveToIList(sceneName);
          Files.SaveElementToProperties(server3, name sceneName);
        }
    }
}
