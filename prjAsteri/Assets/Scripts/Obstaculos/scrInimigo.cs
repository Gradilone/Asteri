using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrInimigo : MonoBehaviour
{
    public float velo = 5f;
    public float esperaTime = .9f;

    public Transform rotaPontos;

    public bool emContatoB = false;
    public bool emContatoA = false;
    nimator anim;
    [SerializeField] Transform posicaoRayCast;
    [SerializeField] float disObs = 2.6f;
    [SerializeField] LayerMask camadaEsquerda;
    [SerializeField] LayerMask camadaDireita;

    private void Start() {
        anim=GetComponent<Animator>();
        Vector2[] pontos = new Vector2[rotaPontos.childCount];
        for (int i = 0; i < pontos.Length; i++)
        {
            pontos[i] = rotaPontos.GetChild (i).position;
            
        }

        StartCoroutine(SeguirRota(pontos));
    }

    private void Update() {
        StartCoroutine(Tempo());

        RaycastHit2D hitPlayer = Physics2D.Raycast(posicaoRayCast.position, Vector2.down * transform.localScale.x, disObs, camadaEsquerda);
        if (hitPlayer.collider != null)
        {
            emContatoB = true;
            emContatoA = false;
            
        }

        RaycastHit2D hitPlayer2 = Physics2D.Raycast(posicaoRayCast.position, Vector2.down * transform.localScale.x, disObs, camadaDireita);
        if (hitPlayer2.collider != null)
        {
            emContatoB = false;
            emContatoA = true;
            
        }
      

       
    }



    IEnumerator SeguirRota(Vector2[] pontos)
    {
        transform.position = pontos [0];
        int pegarPontoIndex = 1;
        Vector3 PontoIndex = pontos[pegarPontoIndex];

        while (true)
        {
            transform.position = Vector2.MoveTowards(transform.position, PontoIndex, velo * Time.deltaTime);
            if (transform.position == PontoIndex)
            {
                pegarPontoIndex = (pegarPontoIndex + 1) % pontos.Length;
                PontoIndex = pontos[pegarPontoIndex];
                yield return new WaitForSeconds (esperaTime);

            }
            yield return null;
        }
    }

    IEnumerator Tempo()
 {
 
     if (emContatoB)
     {
         yield return new WaitForSeconds(esperaTime); 
         VirarDireita();
     }

      if (emContatoA)
     {
         yield return new WaitForSeconds(esperaTime);
         VirarEsquerda();
     }
      
     
 }


    private void OnDrawGizmos() {
        Vector2 inicioPosicao = rotaPontos.GetChild(0).position;
        Vector2 ultimaPosicao = inicioPosicao;
        foreach (Transform pontos in rotaPontos)
        {
            Gizmos.DrawWireSphere (pontos.position, 0.3f);
            Gizmos.DrawLine (ultimaPosicao, pontos.position);
            ultimaPosicao = pontos.position;
        }
        Gizmos.DrawLine(ultimaPosicao, inicioPosicao);

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(posicaoRayCast.position, 0.1f);
    }



    void VirarDireita()
    {
        transform.localScale = new Vector2(-1f,1f);

    }
    void VirarEsquerda()
    {
        transform.localScale = new Vector2(1f,1f);

    }

    /*

    void OnTriggerEnter2D(Collider2D quem)
    {
        if (quem.CompareTag("Esquerda"))
        {
            emContatoB = true;
            emContatoA = false;
        } 

        if (quem.CompareTag("Direita"))
        {
            emContatoB = false;
            emContatoA = true;
        } 

    }
    */

}
