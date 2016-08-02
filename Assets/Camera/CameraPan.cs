using UnityEngine;
using System.Collections;

public class CameraPan : MonoBehaviour {

    private Transform playerTransform;

	// Use this for initialization
	void Start () {
        GameObject player = GameObject.FindWithTag("Player");
        playerTransform = player.transform;
    }

    void LateUpdate()
    {
        transform.LookAt(playerTransform);
    }
}
