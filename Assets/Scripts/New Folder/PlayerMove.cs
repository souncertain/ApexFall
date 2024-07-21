using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMove : MonoBehaviour // - Вместо «PlayerMove» должно быть имя файла скрипта
{
    //------- Функция/метод, выполняемая при запуске игры ---------
    public Rigidbody2D rb;
    public Animator anim;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        //-v- Для автоматического присваивания в переменную, радиуса коллайдера объекта «GroundCheck»
        GroundCheckRadius = GroundCheck.GetComponent<CircleCollider2D>().radius;
    }
    //------- Функция/метод, выполняемая каждый кадр в игре ---------
    void Update()
    {
        
        Reflect();
        Walk();
        Jump();
        Lunge();

        CheckingGround();
    }
     void FixedUpdate()
    {
        
    }
    //------- Функция/метод для перемещения персонажа по горизонтали ---------
    public Vector2 moveVector;
    public int speed = 3;
    void Walk()
    {
        moveVector.x = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveVector.x * speed, rb.velocity.y);
        anim.SetFloat("moveX", Mathf.Abs(moveVector.x));
    }
    //------- Функция/метод для отражения персонажа по горизонтали ---------
    public bool faceRight = true;
    void Reflect()
    {
        if ((moveVector.x > 0 && !faceRight) || (moveVector.x < 0 && faceRight))
        {
            transform.localScale *= new Vector2(-1, 1);
            faceRight = !faceRight;
        }
    }
    //------- Функция/метод для обнаружения земли ---------
    public bool onGround;
    public LayerMask Ground;
    public Transform GroundCheck;
    private float GroundCheckRadius = 0.5f;

    void CheckingGround()

    {
        onGround = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, Ground);
        anim.SetBool("onGround", onGround);
    }
    //------- Функция/метод для прыжка ---------
    public float jumpForce = 210f;
    public int jumpCount = 0;
    private bool jumpControl;
    private float jumpTime = 0;
    public float jumpControlTime = 0.7f;
    public float doubleJumpVelocity = 10f;
    public int maxJumpValue = 0;

    void Jump()
    {


        if (Input.GetKey(KeyCode.Space))
        {
            if (onGround)
            {
                anim.StopPlayback();
                anim.Play("jump");
                rb.velocity = new Vector2(0, jumpForce);
                jumpControl = true;
            }
        }
        else { jumpControl = false; }
        // -----------------------------------

        if (Input.GetKeyDown(KeyCode.Space) && !onGround && (++jumpCount < maxJumpValue))
        {
            anim.StopPlayback();
            anim.Play("doublejump");
            rb.velocity = new Vector2(0, doubleJumpVelocity);

        }
        //------------------------------
        if (onGround) { jumpCount = 0; }
        //------------------------------------
        if (jumpControl)
        {
            if ((jumpTime += Time.deltaTime) < jumpControlTime)
            {
                rb.AddForce(Vector2.up * jumpForce / (jumpTime * 10));
            }
        }
        else { jumpTime = 0; }


    }
    // Метод выполнения рыка
    public int lungeImpulse = 500;


    void Lunge()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        { 
            anim.StopPlayback();
            anim.Play("lunge");

            rb.velocity = new Vector2(0, 0);

            if (!faceRight) { rb.AddForce(Vector2.left * lungeImpulse); }
            else { rb.AddForce(Vector2.right * lungeImpulse); }

        }
    }




}