using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject landingPagePanel = null;

    public void HostLobby()
    {
        landingPagePanel.SetActive(false);
    
        NetworkManager.singleton.StartHost();
    }
}
