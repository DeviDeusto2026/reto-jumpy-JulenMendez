using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraMovement : MonoBehaviour
{
    public GameObject fox;
    public float ySpeed;
    public float deadZone;


    // Update is called once per frame
    void Update()
    {
        float newY = this.transform.position.y + (ySpeed * Time.deltaTime);
        float newX = fox.transform.position.x;
        float z = this.transform.position.z;

        this.transform.position = new Vector3(newX, newY, z);


        if (fox.transform.position.y < this.transform.position.y - deadZone)
        {
            SceneManager.LoadScene("Defeat");
        }
    }
}
