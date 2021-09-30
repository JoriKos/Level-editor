using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D playerRB;
    [SerializeField] private Sprite playerSprite;
    [SerializeField] private float movementSpeed;
    [SerializeField] private ModeToggler modeToggler;
    [SerializeField] private Vector3 startingPosition;
    
    private bool startTimer;
    private float timer;

    private void Awake()
    {
        startingPosition = this.transform.position;
        movementSpeed = 10f;
        playerRB = GetComponent<Rigidbody2D>();
        playerSprite = GetComponent<SpriteRenderer>().sprite;
        startTimer = false;
        Physics.IgnoreLayerCollision(8, 9);
    }

    private void Update()
    {
        if (!modeToggler.GetEditingCheck())
        {
            if (startTimer)
            {
                //Jump timer
                timer += Time.deltaTime;
                if (timer > 1f)
                {
                    timer = 0;
                    startTimer = false;
                }
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector2.right * movementSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector2.left * movementSpeed * Time.deltaTime);
            }
            if (!startTimer)
            {
                if (Input.GetKey(KeyCode.Space))
                {
                    transform.Translate(Vector2.up * (movementSpeed * 10) * Time.deltaTime);
                    startTimer = true;
                }
            }
        }
        if (modeToggler.GetEditingCheck())
        {
            playerRB.velocity = new Vector2(0,0);
            this.transform.position = startingPosition;
        }
    }


}