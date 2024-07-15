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
    publicint sceneCount = 1;
    void Start()
    {
        CreateScene(sceneName, sceneCount);
    }
    public void CreateScene(string sceneName, int sceneCount)
    {
        ListsAndSaves.DeleteAllOnList(Scenes);
        ListsAndSaves.AddAllFromList(i, Scenes);
        ListsAndSaves.CreateList(Scenes);
        ListsAndSaves.AddElementToList(sceneName);
        ListsAndSaves.SaveToIList(sceneName);
        Files.SaveElementToProperties(server:/servers/properties/, )
    }
}
