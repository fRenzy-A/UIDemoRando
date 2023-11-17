using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthOrb : MonoBehaviour
{
    public PlayerUI PlayerUI;
    public PlayerManager PlayerManager;


   
    // Start is called before the first frame update
    void Start()
    {
        PlayerUI = GameObject.Find("PlayerUI").GetComponent<PlayerUI>();
        PlayerManager = GameObject.Find("Player").GetComponent<PlayerManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerUI.pickedUpHealth = true;
            PlayerUI.tempImage.a = 1;
            Destroy(gameObject);
            PlayerManager.Heal(3);
            
        }
    }
}
