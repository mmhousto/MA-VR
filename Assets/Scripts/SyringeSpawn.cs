using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyringeSpawn : MonoBehaviour
{

    public bool needleActivated;
    public bool syringeActivated;
    public GameObject syringe;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Needle") && needleActivated && syringeActivated)
        {
            Instantiate(syringe, transform.position, transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }

    public void ActivateNeedle()
    {
        needleActivated = true;
    }

    public void DeactivateNeedle()
    {
        needleActivated = false;
    }

    public void ActivateSyringe()
    {
        syringeActivated = true;
    }

    public void DeactivateSyringe()
    {
        syringeActivated = false;
    }
}
