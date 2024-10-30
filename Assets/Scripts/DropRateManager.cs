using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropRateManager : MonoBehaviour
{
    [System.Serializable]
    public class Drops
    {
        public string name;
        public GameObject itemPrefab;
        public float dropRate;
    }

    public List<Drops> drops;

    void OnDestroy()
    {
        float randomNumber = Random.Range(0f, 100f);
        List<Drops> possibleDrops = new List<Drops>();

        foreach (Drops drop in drops)
        {
            if(randomNumber <= drop.dropRate)
            {
                possibleDrops.Add(drop);
            }

        }
        if(possibleDrops.Count > 0)
        {
            possibleDrops.Sort((a,b) => a.dropRate.CompareTo(b.dropRate));
            Drops dropToSpawn = possibleDrops[0];
            Instantiate(dropToSpawn.itemPrefab, transform.position, Quaternion.identity);
        }
    }
}
