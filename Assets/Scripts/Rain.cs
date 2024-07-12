using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Rain : MonoBehaviour
{
    public Light dirLight;
    private ParticleSystem _ps;
    private bool _isRain;
    private void Start()
    {
        _ps = GetComponent<ParticleSystem>();
        StartCoroutine(Weather());
    }

    private void Update()
    {
        if (_isRain && dirLight.intensity > 0.22f)
            LightIntensity(-1);
        else if (!_isRain && dirLight.intensity < 0.435f)
            LightIntensity(1);



    }

    private void LightIntensity(int v)
    {
        dirLight.intensity += 0.1f * Time.deltaTime * v;
    }

    IEnumerator Weather()
        {
            while (true)
            {
                yield return new WaitForSeconds(UnityEngine.Random.Range(10f,15f));

            if (_isRain)
                _ps.Stop();
            else
                _ps.Play();

            _isRain = !_isRain;

            }
        }
    }

