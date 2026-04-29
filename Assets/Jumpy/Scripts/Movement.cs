using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private int velocity;

    [SerializeField]
    private int jump;

    [SerializeField]
    private bool can_jump = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position += Vector3.left * velocity * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += Vector3.right * velocity * Time.deltaTime;
        }
        if (can_jump && Input.GetKeyDown(KeyCode.Space))
        {
            this.GetComponent<Rigidbody>().AddForce(transform.up * jump);
        }
    }

    void FixedUpdate()
    {
        //if (can_jump && Input.GetKeyDown(KeyCode.Space))
        //{
        //    this.GetComponent<Rigidbody>().AddForce(transform.up * jump);
        //}
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            can_jump = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            can_jump = false;
        }
    }
}
