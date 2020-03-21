using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarShoot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obstacle;
    void Start()
    {
         Instantiate(obstacle, transform.position, Quaternion.identity);
    }
    void Update()
    {
       Destroy(gameObject , 5.0f);
    }
}
