using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] float destroyDelay = 0.5f;
    bool hasPackage;

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("package picked up");
            hasPackage = true;
            Destroy(other.gameObject, destroyDelay);
        }
        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("delivered package");
            hasPackage = false;
        }
    }
}
