using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfileView : MonoBehaviour
{
    private bool isOpen = false;

    void Start()
    {
        if (gameObject.activeSelf && !isOpen)
        {
            // if the object is already active, then close it
            gameObject.SetActive(false);
        }
    }

    public void TryToOpenProfile()
    {
        if (gameObject.activeSelf)
        {
            // if the object is already active, then close it
            gameObject.SetActive(false);
            isOpen = false;
        }
        else
        {
            // if the object is not active, then open it
            gameObject.SetActive(true);
            isOpen = true;
        }
    }
}
