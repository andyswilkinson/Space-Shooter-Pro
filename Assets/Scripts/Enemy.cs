using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Set speed variable
    [SerializeField]
    private float _speed = 4f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Move down at 4 meters per second
        transform.Translate(Vector3.down * _speed * Time.deltaTime);

        // If Bottom of Screen
        // Respawn at top with a new random X Position
        if(transform.position.y < -5f)
        {
            float randomX = Random.Range(-8f, 8f);
            transform.position = new Vector3(randomX, 7f, 0);
        }
    }

    private void onTriggerEnter(Collider other)
    {
        Debug.Log("Hit: " + other.transform.name);
    }
}
