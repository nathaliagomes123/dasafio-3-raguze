using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class Save : MonoBehaviour
{
    public Player p1 = new Player();
    // Start is called before the first frame update
    void Start()
    {
         p1.name = "Ash";
        p1.pokemons.Add(new Pokemons {
        pokemonname = "Pikachu",
        level = 10
        });
   
         p1.pokemons.Add(new Pokemons {
        pokemonname = "Charmander",
        level = 5
        });

            p1.pokemons.Add(new Pokemons {
        pokemonname = "Arbok",
        level = 8
        });

              p1.pokemons.Add(new Pokemons {
        pokemonname = "Psyduck",
        level = 4
        });

            p1.pokemons.Add(new Pokemons {
        pokemonname = "Snorlax",
        level = 9
        });
  

         p1.itens.Add(new Itens {
     name = "Pokebola",
       quantity = 50
        });
  
  
         p1.itens.Add(new Itens {
     name = "Passe de batalha",
       quantity = 3
        });
  
  
         p1.itens.Add(new Itens {
     name = "Poçoes",
       quantity = 20
        });
  
         p1.itens.Add(new Itens {
     name = "Frutas",
       quantity = 30
        });
  
  
         p1.itens.Add(new Itens {
     name = "Incubadora pokemon",
       quantity = 30
        });


    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.U))
        {
            savetojson();

        }

  }

    public void savetojson()
    {
        string json = JsonUtility.ToJson(p1,true);
        string dir = Application.dataPath + "/Resources/save.json";
        // if(!Directory.Exists(dir))
        // {
        //     Directory.CreateDirectory(dir);
        // }
        File.WriteAllText(dir, json); 
    }



}





