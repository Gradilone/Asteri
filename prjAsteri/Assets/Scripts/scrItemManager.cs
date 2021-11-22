using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

public class scrItemManager : MonoBehaviour
{
    [SerializeField] public List<string> itensInv = new List<string>();

    public static scrItemManager Instance { get; private set; }

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
