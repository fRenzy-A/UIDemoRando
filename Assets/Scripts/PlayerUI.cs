using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public Canvas HealthPickedUp;
    public Canvas QuestMarker;
    public Image image;
    public Image marker;
    float time;
    public Color tempImage;
    public TMP_Text magCount;

    public GunHandler gunHandler;

    public bool pickedUpHealth;
    // Start is called before the first frame update
    void Start()
    {
        HealthPickedUp = GameObject.Find("HPGetCanvas").GetComponentInChildren<Canvas>();
        HealthPickedUp.enabled = false;
        image = GameObject.Find("GotHealth").GetComponent<Image>();
        marker = GameObject.Find("Marker").GetComponent<Image>();
        tempImage = image.color;
        
        gunHandler = GameObject.Find("GunLOL").GetComponent<GunHandler>();
        magCount = GameObject.Find("MagazineNumber").GetComponent<TMP_Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //OnHealthPickup();
    }
    private void FixedUpdate()
    {
        ShowMarker();
        if (pickedUpHealth)
        {
            OnHealthPickup();
        }
        DisplayMagCount();
    }

    public void OnHealthPickup()
    {        
        HealthPickedUp.enabled=true;
        
        tempImage.a -= Time.deltaTime;
        image.color = tempImage;
        if (tempImage.a < 0)
        {
            tempImage.a = 1;
            HealthPickedUp.enabled = false;
            pickedUpHealth = false;
        }

    }

    public void ShowMarker()
    {
        marker.transform.position = GameObject.Find("Cube").transform.position;
        marker.transform.position = new Vector3(marker.transform.position.x,marker.transform.position.y+2,marker.transform.position.z);
        /*Vector3 targetPos = marker.transform.position;
        marker.anchoredPosition = new Vector3(targetPos.x,targetPos.y+10,targetPos.z);*/
    }

    public void DisplayMagCount()
    {
        magCount.text = gunHandler.ammoCount.text;
    }
}
