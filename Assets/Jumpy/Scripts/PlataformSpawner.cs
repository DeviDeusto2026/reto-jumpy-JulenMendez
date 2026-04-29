using UnityEngine;

public class PlataformSpawner : MonoBehaviour
{
    public GameObject plataform;
    public GameObject victoryPlataform;

    public int numberOfPlataforms;

    public float altura;
    public float xRange;

    public GameObject fox;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 1; i < numberOfPlataforms; i++)
        {
            GameObject newPlataform = Instantiate(plataform);
            newPlataform.transform.position = GetRandomPosition(i);
            newPlataform.GetComponent<PlatformBehaivor>().fox = fox;
        }

        GameObject newVictoryPlataform = Instantiate(victoryPlataform);
        newVictoryPlataform.transform.position = GetRandomPosition(numberOfPlataforms);
        newVictoryPlataform.GetComponent<PlatformBehaivor>().fox = fox;
    }

    private Vector3 GetRandomPosition(int nPlataform)
    {
        float randomX = Random.Range(-xRange, xRange);

        return new Vector3(randomX, nPlataform * altura, 0);
    }
}
