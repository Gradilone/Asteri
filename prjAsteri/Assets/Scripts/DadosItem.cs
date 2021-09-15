using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Novo Item", menuName = "Inventario/Item")]
public class DadosItem : ScriptableObject 
    {
        public new string name = "Novo Item";
        public Sprite icon = null;
        public bool PodePegar = false; 
        public string descricao; 
    }

