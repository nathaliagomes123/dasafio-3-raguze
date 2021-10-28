using UnityEngine;
using System.Collections;
using System.Collections.Generic;
[System.Serializable]
public class Player
{
    public string name;
    
    public List<Pokemons> pokemons = new List<Pokemons>();
    public List<Itens> itens = new List<Itens>();
}

