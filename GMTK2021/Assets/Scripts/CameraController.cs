using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player1;
    public Transform player2;
    public float heightMultiplier;
    void Update()
    {
        Vector3 newPosition = new Vector3();
        newPosition.x = (player2.position.x + player1.position.x*4)/5;
        newPosition.z = (player2.position.z + player1.position.z*4)/5;
        newPosition.y = Vector3.Distance(player2.position, player1.position) * heightMultiplier;
        transform.position = newPosition;
    }
}
