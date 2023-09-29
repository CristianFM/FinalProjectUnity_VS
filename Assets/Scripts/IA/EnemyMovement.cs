using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Transform playerTransform;
    [SerializeField] private CharacterController characterController;

    [SerializeField] private float speed;

    // Start is called before the first frame update
    void Awake()
    {
        characterController = GetComponent<CharacterController>();
        player = GameObject.FindGameObjectWithTag("User");
        playerTransform = player.transform;
        speed = 3f;

    }

    // Update is called once per frame
    void Update()
    {
        move();
    }


    private void move()
    {
        transform.LookAt(playerTransform.position);
        Vector3 movement = transform.TransformDirection(Vector3.forward);
        characterController.Move(movement * Time.deltaTime * speed);
    }
}
