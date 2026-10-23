using UnityEngine;
using UnityEngine.InputSystem;

public class MapManger : MonoBehaviour
{
    [SerializeField] private GameObject[] maps;

    private float timer;

    private int mapnum = 0;

    private void Start()
    {
        ChangeMap();
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if(timer > 20)
        {
            timer = 0;
            ChangeMap();
        }
    }

    public void ChangeMap()
    {
        for (int i = 0; i < maps.Length; i++)
        {
            if(i==mapnum % 3)
            {
                maps[mapnum%3]?.SetActive(true);
                continue;
            }
            maps[i]?.SetActive(false);
        }
        mapnum++;
    }
}
