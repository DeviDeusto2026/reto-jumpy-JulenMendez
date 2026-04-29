using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryPlataform : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.transform.position.y > this.gameObject.transform.position.y)
        {
            SceneManager.LoadScene("Victory");
        }
    }
}
