using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PortaContato : MonoBehaviour
{ 
    [SerializeField] Transform posicaoRayCast;
    [SerializeField] float disObs = 2.6f;
    [SerializeField] LayerMask camadaObs;
    public bool emContato;

    void Update() {
        RaycastHit2D hitPlayer = Physics2D.Raycast(posicaoRayCast.position, Vector2.down * transform.localScale.x, disObs, camadaObs);
        if (hitPlayer.collider != null)
        {
            emContato = true;
            
        }
        else
        {
            emContato = false;
        }
    }
    private void OnDrawGizmos() 
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(posicaoRayCast.position, (Vector2)posicaoRayCast.position + Vector2.down * transform.localScale.x * disObs);
    }

    public void Porta()
    {
        Debug.Log("Sla");

    }


  

}
