using UnityEngine;

public class PlatformBehaivor : MonoBehaviour
{
    public GameObject fox;
    private Collider platformCollider;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        platformCollider = this.gameObject.GetComponent<Collider>();
        platformCollider.isTrigger = true;
    }

    // Update is called once per frame
    void Update()
    {
        float foxSpeed = fox.GetComponent<Rigidbody>().linearVelocity.y;
        
        platformCollider.isTrigger = foxSpeed > 0;
    }
}
