using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{
    public bool isGrounded = false;
    private bool isJumping = false;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0.1f, 0.1f, -0.0001f);
        // Gestion de l'animation 
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        if (h < 0)
        {
            transform.Translate(Vector2.right);
        }
    }
}
