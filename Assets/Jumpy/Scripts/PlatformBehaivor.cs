using UnityEngine;

public class PlatformBehaivor : MonoBehaviour
{
    public GameObject fox;
    private Collider platformCollider;
    private Rigidbody foxRb;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        platformCollider = this.gameObject.GetComponent<Collider>();
        platformCollider.isTrigger = true;
        foxRb = fox.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        platformCollider.isTrigger = foxRb.linearVelocity.y > 0;
    }
}
