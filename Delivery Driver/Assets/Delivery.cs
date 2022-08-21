using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    // default bool value is false 
    [SerializeField] Color32 hasPackageColor =  new Color32(1, 1, 1, 1); 
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1); 
    [SerializeField] float destroyDelay = 0.5f; 
    bool hasPackage; 

    SpriteRenderer spriteRenderer;

    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Ouch!");
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        


        // if (the thing we trigger is the package)
        // then print "package picked up" to the console
        // Hint: use tags to figure what object trigger
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up!");
            hasPackage = true; 
            Destroy(other.gameObject, destroyDelay);
            spriteRenderer.color = hasPackageColor;
        }
        
        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Delivered package!");
            hasPackage = false; 
            spriteRenderer.color = noPackageColor;
        }
    }
}
