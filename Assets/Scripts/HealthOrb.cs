using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthOrb : MonoBehaviour
{
    public PlayerUI PlayerUI;
    // Start is called before the first frame update
    void Start()
    {
        PlayerUI = GameObject.Find("PlayerUI").GetComponent<PlayerUI>();
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
        }
    }
}
