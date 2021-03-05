using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;
    [SerializeField] private Vector3 offset = new Vector3(0, 4, -9);

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Player.transform.position + offset;
    }
}
