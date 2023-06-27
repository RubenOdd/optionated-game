using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerKeyInteractions : MonoBehaviour
{   
    private bool isActivated = false;
    public GameObject profileView;
    public GameObject inventoryView;


    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            profileView.GetComponent<ProfileView>().TryToOpenProfile();

        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            inventoryView.GetComponent<InventoryView>().TryToOpenInventory();
        }
    }
}
