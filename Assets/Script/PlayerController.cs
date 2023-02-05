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
    private Transform mTransform;

    public GameObject DeathEffect;
    public GameObject Player;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        mTransform = this.transform;
    }

    private void Update()
    {
        LookAtMouse();
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
    }

    private void LookAtMouse()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - mTransform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        mTransform.rotation = rotation;
    }

    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Mouse0))
        {
            rb.MovePosition(position);
        }

        if(Input.GetKeyUp(KeyCode.Mouse0))
        {
            //Debug.Log("Saucisse");
        }
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.CompareTag("DeathZone"))
        {
            Destroy(Player);
            Instantiate(DeathEffect, transform.position, transform.rotation);
            StartCoroutine(Death());
        }
    }

    IEnumerator Death()
    {
        yield return new WaitForSeconds(2);
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
