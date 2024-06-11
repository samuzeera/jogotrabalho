using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoDoJogador : MonoBehaviour
{
    public float velocidadeDoJogador;

    public float alturaDoPulo;

    public Rigidbody2D oRigidbody2D;

    public SpriteRenderer oSpriteRenderer;

    public bool estaNoChao;

    public Transform verificadorDeChao;
     
    public float raioDeVerificacao;

    public LayerMask layerDoChao;

    public AudioSource somDoPulo;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void   FixedUpdate()
    {
        MovimentarJogador();
        Pular();
    }


    public void MovimentarJogador()
    {
        float inputDoMovimento = Input.GetAxisRaw("Horizontal");
        oRigidbody2D.velocity = new Vector2(inputDoMovimento * velocidadeDoJogador, oRigidbody2D.velocity.y);
        
        if(inputDoMovimento > 0)
        {
          oSpriteRenderer.flipX = false;
        }
        if(inputDoMovimento < 0)
        {
            oSpriteRenderer.flipX = true;
        }

    }
    public void Pular()
    {
        estaNoChao = Physics2D.OverlapCircle(verificadorDeChao.position, raioDeVerificacao, layerDoChao);

        if(Input.GetKeyDown(KeyCode.Space) && estaNoChao == true)
        {
            oRigidbody2D.velocity = Vector2.up * alturaDoPulo;
            somDoPulo.Play();
        }
    }




}

