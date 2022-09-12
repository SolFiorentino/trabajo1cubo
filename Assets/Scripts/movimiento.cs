using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class movimiento : MonoBehaviour
{
    Rigidbody componente;

    private void Start()
    { //Componente trae el componente del rigidbody ekisde
        componente = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            componente.velocity = new Vector3(0, 3, 0);
        }

        if (Input.GetKeyDown("right"))
        {
            componente.velocity = new Vector3(3, 0, 0);
        }

        if (Input.GetKeyDown("down"))
        {
            componente.velocity = new Vector3(0, 0, -3);
        }

        if (Input.GetKeyDown("up"))
        {
            componente.velocity = new Vector3(0, 0, 3);
        }

        if (Input.GetKeyDown("left"))
        {
            componente.velocity = new Vector3(-3, 0, 0);
        }

        if (Input.GetKeyDown("s"))
        {
            componente.velocity = new Vector3(0, -3, 0);
        }

    }
}
