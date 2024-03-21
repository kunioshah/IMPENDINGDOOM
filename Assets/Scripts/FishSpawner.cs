using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    public GameObject SmolGameObject;
    public GameObject MedGameObject;
    public GameObject BeegGameObject;
  
    public float FishSpawnTimeNow;
    public float FishSpawnTime;
    public float numberOfFish;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Fish").Length < numberOfFish)
        {
            if (FishSpawnTimeNow <= 0)
            {
                spawnDem();
                //when fish spawn, reset timer to spawn again
                FishSpawnTimeNow = FishSpawnTime;
            }
            else
            {
                //count down time by 1 sec
                FishSpawnTimeNow -= Time.deltaTime;
            }
        }
       
    }
    public void spawnDem()
    {
        //Make array for feesh
        GameObject[] fishSize = new GameObject[]{ SmolGameObject, SmolGameObject, SmolGameObject, SmolGameObject, 
            SmolGameObject, MedGameObject, MedGameObject, MedGameObject, BeegGameObject, BeegGameObject};
        //Now we choose random feesh
        int chosenOne = Random.Range(0, fishSize.Length);

        //We choose random spawn
        Vector2 randoSpawn = new Vector2(Random.Range(-103, 106), Random.Range(49, -49));
        //public bool OverlapPoint(randoSpawn);
        //do
        {
            randoSpawn = new (Random.Range(-103, 106), Random.Range(49, -49));
        } //while (OverlapPoint(randoSpawn));

        //Spawn the feesh
        Instantiate(fishSize[chosenOne], randoSpawn, Quaternion.identity);

        //Oh yeah also talk about which one it chose
        Debug.Log(chosenOne);
        //Maybe where it is, too
        Debug.Log(randoSpawn);
    }
}
