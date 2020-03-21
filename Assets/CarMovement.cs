using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    void Update()
    {
        if (Player.dead != true)
        {
            transform.Translate(Vector3.back * 20f * Time.deltaTime);
            Destroy(gameObject, 10.0f);
        }
    }
}
