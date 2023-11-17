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

    public Slider ammoBar;


    public GameManager gameManager;

    public AudioSource ShootSound;
    public AudioSource ReloadSound;
    // Start is called before the first frame update
    void Start()
    {
        ammoCount = GameObject.Find("AmmoCount").GetComponent<TMP_Text>();
        shootAnimation = gameObject.GetComponent<Animator>();
        ammoCount.SetText(magazineSize.ToString());
        ShootSound = GameObject.Find("Shoot_Sound").GetComponent<AudioSource>();
        ReloadSound = GameObject.Find("Reload_Sound").GetComponent<AudioSource>();

        ammoBar = GameObject.Find("AmmoBar").GetComponent<Slider>();

        ammoBar.maxValue = magazineSize;
        ammoBar.value = ammoBar.maxValue;
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
            shootAnimation.Play("Reload");
            
        }
    }

    public void ReloadThisGun()
    {
        shootAnimation.SetBool("Reload", true);
        ammoCount.SetText(" ");
        ReloadSound.Play();
    }
    public void GunReloaded()
    {
        shootAnimation.SetBool("Reload", false);
        ammoCount.SetText(magazineSize.ToString());
    }

    public void GunIsShot()
    {
        
        int currentAmmoCount = int.Parse(ammoCount.text);
        
        if (currentAmmoCount == 0)
        {
            shootAnimation.Play("Reload");
            ammoBar.value = currentAmmoCount;
        }
        else
        {
            ammoBar.value = currentAmmoCount;
            currentAmmoCount -= 1;
            ammoCount.text = currentAmmoCount.ToString();
            ShootSound.Play();
        }
    }
    
    public void GunIsSettled()
    {
        //im using animation events and apparently this is a hacky way of the gun not depleting ammo while in its shoot animation state
    }
}
