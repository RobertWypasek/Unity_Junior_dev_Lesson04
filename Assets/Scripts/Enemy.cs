using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float speed = 3.0f;
    private Vector3 playerPosition;
    private Rigidbody enemyRb;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = playerPosition - transform.position;
        enemyRb.AddForce(playerPosition.normalized * speed);
    }
}
