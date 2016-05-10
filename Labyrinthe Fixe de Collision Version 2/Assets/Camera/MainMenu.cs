using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{

    GameObject NetworkMaster;  //Prefab
    private GameObject InstantiatedMaster; //Prefab instancié
    private StartNetwork ScriptStartNet;
    private string ServerIp = "127.0.0.1";
    private int ServerPort = 25000;

    void OnGUI()
    {
        int menuSizeX = 460;
        int menuSizeY = 115;
        float menuPosX = 20;
        float menuPosY = Screen.height / 2 - menuSizeY / 2;
        var mainMenu = new Rect(menuPosX, menuPosY, menuSizeX, menuSizeY);
        int sizeButtonX = 250;
        int sizeButtonY = 30;

        //Menu de base
        GUI.BeginGroup(mainMenu, "");
        GUI.Box(new Rect(0, 0, menuSizeX, menuSizeY), "");

        //Demande d'IP pour rejoindre
        ServerIp = GUI.TextField(new Rect(sizeButtonX + 30, 60, 120, 30), ServerIp, 40);

        if (GUI.Button(new Rect(10, 20, sizeButtonX, sizeButtonY), "Créer serveur"))
        {
            //Création du serveur
            InstantiatedMaster = Instantiate(NetworkMaster, Vector3.zero, Quaternion.identity) as GameObject;
            ScriptStartNet = InstantiatedMaster.GetComponent<StartNetwork>();
            
        }
        if (GUI.Button(new Rect(10, 60, sizeButtonX, sizeButtonY), "Rejoindre serveur"))
        {
            //Rejoindre serveur
            InstantiatedMaster = Instantiate(NetworkMaster, Vector3.zero, Quaternion.identity) as GameObject;
            ScriptStartNet = InstantiatedMaster.GetComponent<StartNetwork>();
            
        }
        GUI.EndGroup();

    }

}
