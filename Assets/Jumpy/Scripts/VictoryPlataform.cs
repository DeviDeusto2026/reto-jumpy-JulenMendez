using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryPlataform : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene("Victory");
    }
}
