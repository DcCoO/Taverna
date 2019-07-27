using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceManager : MonoBehaviour {

    public static InterfaceManager instance = null;

    public GameObject storeScreen, inventoryScreen, missionScreen;


    private void Awake() {
        instance = this;
    }
    
    public void OpenStore() {
        storeScreen.SetActive(true);
    }

    public void OpenInventory() {
        inventoryScreen.SetActive(true);
    }

    public void OpenMissions() {
        missionScreen.SetActive(true);
    }

    public void CloseAll() {
        missionScreen.SetActive(false); inventoryScreen.SetActive(false); storeScreen.SetActive(false);
    }

}
