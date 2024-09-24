using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mechanim : MonoBehaviour
{
    Animator ani;

    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            ani.SetInteger("ianiIndex", 0);
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            ani.SetInteger("ianiIndex", 1);
        }
        if (Input.GetKeyDown(KeyCode.F3))
        {
            ani.SetInteger("ianiIndex", 2);
        }
    }
}
