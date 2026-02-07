using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;

public class menuSpawner : MonoBehaviour
{
    [System.Serializable]
    public class SpawnSettings
    {
        public string name;
        public Sprite sprite;
        public Vector2 spawnPos;
        public Vector2 endPos;
    }

    [Header("prefab")]
    public GameObject prefabBase;
    public List<SpawnSettings> spawnlist;
    
    [Header("settings")]
    public float moveDuration = 2f;
    public float delayBetweenSpawns = 1f;

    private void Start()
    {
        if (prefabBase == null || spawnlist.Count == 0) return;
        StartCoroutine(SpawnLoop());
    }

    IEnumerator SpawnLoop()
    {
        int currentIndex = 0;

        while (true)
        {
            SpawnSettings settings = spawnlist[currentIndex];
            GameObject newObj = Instantiate(prefabBase, settings.spawnPos, Quaternion.identity);
            
            if (settings.sprite != null)
            {
                newObj.GetComponent<SpriteRenderer>().sprite = settings.sprite;
            }

            newObj.transform.DOMove(settings.endPos, moveDuration)
                .SetEase(Ease.Linear)
                .OnComplete(() => Destroy(newObj));

            currentIndex = (currentIndex + 1) % spawnlist.Count;

            yield return new WaitForSeconds(delayBetweenSpawns);
        }
    }
}
