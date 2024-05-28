using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Injection : MonoBehaviour
{

    public bool canPoke = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Syringe") && canPoke)
        {
            // Play Anim
            Debug.Log("Injection Complete");
        }
    }

    public void EnablePoke()
    {
        canPoke = true;
    }

    public void DisablePoke()
    {
        canPoke = false;
    }

}
