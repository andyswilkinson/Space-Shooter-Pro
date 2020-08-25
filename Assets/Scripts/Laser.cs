using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    // Speed Variable of 8
    [SerializeField]
    private float _speed = 8.0f;

    // Update is called once per frame
    void Update()
    {
        // Translate laser up
        transform.Translate(Vector3.up * _speed * Time.deltaTime);

        // If Laser Position is > 8 on y
        // Then Destroy the object
        if(transform.position.y > 8f)
        {
            Destroy(this.gameObject);
        }
    }
}
