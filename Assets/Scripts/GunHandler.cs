using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class GunHandler : MonoBehaviour
{
    public TMP_Text ammoCount;
    public int magazineSize;


    public Animator shootAnimation;
    // Start is called before the first frame update
    void Start()
    {
        ammoCount = GameObject.Find("AmmoCount").GetComponent<TMP_Text>();
        shootAnimation = gameObject.GetComponent<Animator>();
        ammoCount.SetText(magazineSize.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            shootAnimation.Play("Shoot");
        }
        if (Input.GetKeyDown(KeyCode.R)) 
        {
            ReloadThisGun();
        }

    }

    public void ReloadThisGun()
    {
        ammoCount.SetText(magazineSize.ToString());
    }

    public void GunIsShot()
    {
        
        int currentAmmoCount = int.Parse(ammoCount.text);
        
        if (currentAmmoCount > 0)
        {
            currentAmmoCount -= 1;
            ammoCount.text = currentAmmoCount.ToString();
        }
        else return;
    }

    public void GunIsSettled()
    {
        
    }
}
