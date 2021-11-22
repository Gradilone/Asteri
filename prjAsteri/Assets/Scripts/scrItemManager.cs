using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

public class scrItemManager : MonoBehaviour
{
    [SerializeField] public List<string> itensInv = new List<string>();

    [SerializeField] public bool portaAbriu=false;

    public static scrItemManager Instance { get; private set; }

    public bool FioAmarelo=false;

    public bool FioAzul=false;

    public bool FioVermelho=false;

    public bool FioVerde=false;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
        
        DontDestroyOnLoad(gameObject);
    }

    public void Compare(GameObject atual)
    {
        if(itensInv.Contains(atual.name))
        {
            Destroy(atual);
        }
    }

    public bool CompareName(string atualis)
    {
        if(itensInv.Contains(atualis))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
