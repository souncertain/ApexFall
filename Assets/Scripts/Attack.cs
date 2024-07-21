using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if ((col.gameObject.tag == "enemy") && (gameObject.GetComponent<Movement>().isDashing == true))
        {
            Destroy(col.gameObject);

        }

    }
}
