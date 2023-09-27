using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    // Start is called before the first frame update
    static Singleton Instance;
    void Start()
    {
        if(Instance != null)
        {
            GameObject.Destroy(gameObject);
        }
        else
        {
            GameObject.DontDestroyOnLoad(gameObject); 
            Instance = this;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
