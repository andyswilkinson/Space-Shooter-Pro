using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private IEnumerator coroutine;
    // Variable for Enemy Prefab
    [SerializeField]
    private GameObject _enemyPrefab;

    void Start()
    {
        // Initialize
        Debug.Log("SpawnRoutine Starts 5 seconds from " + Time.time);

        // Start CoRoutine
        coroutine = SpawnRoutine(5.0f);
        StartCoroutine(coroutine);
    }

    // Update is called once per frame
    void Update()
    {
    }

    //spawn game objects every 5 seconds
    // Create a coroutine of type IEnumerator -- Yield Events
    // yield keyword allows us to wait for n number of seconds
    // while loop

    IEnumerator SpawnRoutine(float DelaySeconds)
    {
        // while loop (infinite loop)-important to be infinite beause we can use "yield"
            // Instantiate enemy prefab
            // yield wait for 5 seconds
        while(true)
        {
            float randomX = Random.Range(-8f, 8f);
            Instantiate(_enemyPrefab, transform.position + new Vector3(randomX, 7f, 0), Quaternion.identity);
            yield return new WaitForSeconds(DelaySeconds);
            Debug.Log("Elapsed Time " + Time.time);
        }
    }

}
