using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneRotation : MonoBehaviour
{
    [SerializeField] GameObject _rotationPlanform;
    public GameObject[] playersPrefabs;
    public GameObject[] _players;
    public int _characterIndex = 0;

    private Quaternion _targetRotation;
    private float _angle;

    void Start()
    {
        _targetRotation = _rotationPlanform.transform.rotation;
        _players = new GameObject[playersPrefabs.Length];
        _angle = GetStepRotation();
        SpawnPlayers();
    }

    void Update()
    {
        _rotationPlanform.transform.rotation = Quaternion.Lerp(_rotationPlanform.transform.rotation, _targetRotation, Time.deltaTime * 5);
    }


    public void RotateLeft()
    {
        _characterIndex -= 1;
        if (_characterIndex < 0)
            _characterIndex = _players.Length - 1;
        Rotate(-_angle);
    }
    public void RotateRight()
    {
        _characterIndex += 1;
        _characterIndex %= _players.Length;
        Rotate(+_angle);
    }
    private void Rotate(float angle)
    {
        _targetRotation *= Quaternion.Euler(0, angle, 0);
        //Debug.Log(_targetRotation);
    }
    private float GetStepRotation()
    {
        return 360f / _players.Length;
    }


    public void SpawnPlayers()
    {
        for (int i = 0; i < _players.Length; i++)
        {
            Vector3 playerPosition = _rotationPlanform.transform.position + new Vector3(Mathf.Cos(_angle * i * Mathf.Deg2Rad), 0, Mathf.Sin(_angle * i * Mathf.Deg2Rad)) * 5;
            _players[i] = Instantiate(playersPrefabs[i], playerPosition, Quaternion.identity);
            _players[i].transform.parent = _rotationPlanform.transform;
        }
    }




}
