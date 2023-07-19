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
    private bool canMove = true;

    public Joystick joystick;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (canMove)
        {
            Vector3 movement = new Vector3(joystick.Horizontal, joystick.Vertical, 0f);

            // Calcola il valore assoluto del movimento lungo gli assi orizzontali e verticali
            float absHorizontal = Mathf.Abs(movement.x);
            float absVertical = Mathf.Abs(movement.y);

            // Se il movimento è principalmente orizzontale, controlla la direzione destra/sinistra
            if (absHorizontal > absVertical)
            {
                if (movement.x < 0)
                {
                    spriteRenderer.sprite = WalkLeft;
                    transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
                }
                else if (movement.x > 0)
                {
                    spriteRenderer.sprite = WalkRight;
                    transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
                }
            }
            // Altrimenti, controlla la direzione sopra/sotto
            else
            {
                if (movement.y > 0)
                {
                    spriteRenderer.sprite = WalkBack;
                }
                else if (movement.y < 0)
                {
                    spriteRenderer.sprite = Walk1;
                }
            }

            transform.position += movement * speed * Time.deltaTime;
        }
    }

    // Metodo pubblico per consentire di disabilitare o riabilitare il movimento del personaggio.
    public void SetCanMove(bool canMove)
    {
        this.canMove = canMove;
    }
}
