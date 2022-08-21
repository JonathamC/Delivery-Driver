using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControlScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static MusicControlScript instance; 

    void Awake() 
    {
        DontDestroyOnLoad(this.gameObject); 
        if (instance == null)
        {
            instance = this; 
        }
        else 
        {
            Destroy(gameObject);
        }
    }
}
