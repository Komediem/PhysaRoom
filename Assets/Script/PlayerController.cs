using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Vector3 mousePosition;
    public float moveSpeed = 0.05f;
    Rigidbody2D rb;
    Vector2 position = new Vector2(0f, 0f);

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
    }

    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Mouse0))
        {
            rb.MovePosition(position);
        }

        if(Input.GetKeyUp(KeyCode.Mouse0))
        {
            Debug.Log("Saucisse");
        }
    }


    public void Death()
    {
        //SceneManager.LoadScene
    }
}
