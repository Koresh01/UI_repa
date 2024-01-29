using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class get_difficulty : MonoBehaviour
{
    [SerializeField] private int _level;
    [SerializeField] private int _difficulty;
    private List<GameObject> toggles;

    private void Start()
    {
        /*
        toggles = new List<GameObject>(transform.getcomponentin);
        toggles = transform.GetComponentsInChildren<Toggle>;
        */
        int n = transform.childCount;
        toggles = new List<GameObject>();
        for (int i = 0; i < n; i++)
        {
            toggles.Add(transform.GetChild(i).gameObject);
        }
    }
        
    public void GetDifficutly() {
        for(int i = 0; i < toggles.Count; i++)
        {
            if (toggles[i].GetComponent<Toggle>().isOn) {
                Dropdown dp = toggles[i].GetComponentInChildren<Dropdown>();
                _difficulty = dp.value;
                _level = i+1;
            }
        }
        
    }
    
}
