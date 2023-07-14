using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 9f;

    public Sprite Walk1;
    public Sprite WalkLeft;
    public Sprite WalkRight;
    public Sprite WalkBack;


    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
  

        if (movement.x < 0)
        {
            spriteRenderer.sprite = WalkLeft;
            transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        }
        else if (movement.x > 0)
        {
            spriteRenderer.sprite = WalkRight;
            transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        }
        else if (movement.y > 0)
        {
            spriteRenderer.sprite = WalkBack;
        }
        else if (movement.y < 0)
        {
            spriteRenderer.sprite = Walk1;
        }

        transform.position += movement * speed * Time.deltaTime;
    }
}
