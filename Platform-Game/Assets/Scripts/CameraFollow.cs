using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerCharacter;
    public float cameraDistance = 10.0f;

    void Awake()
    {
        GetComponent<UnityEngine.Camera>().orthographicSize = ((Screen.height / 3.5f) / cameraDistance);
    }

    void FixedUpdate()
    {
        transform.position = new Vector3(playerCharacter.position.x, playerCharacter.position.y, transform.position.z);
    }
}
