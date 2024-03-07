using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Audio
{

    public class AudioController : MonoBehaviour
    {
        private AudioSource _source;
        private AudioClip _clip;
        private float _startPoint;
        private float _endPoint;

        public void SetParameters(AudioSource source, AudioClip clip, float startPoint = 0,
            float endPoint = int.MaxValue)
        {
            _source = source;
            _clip = clip;
            _startPoint = startPoint;
            _endPoint = endPoint;
        }
        
        public void PlayAudio()
        {
            if (!_source.isPlaying)
            {
                _source.clip = _clip;
                _source.time = _startPoint;
                _source.Play();
            }
        }

        public void ToggleAudio(bool cancel = false)
        {
            if (cancel)
            {
                CancelInvoke(nameof(ToggleAudio));
                _source.Stop();
                return;
            }
            _source.clip = _clip;
            _source.time = _startPoint;
            _source.Play();
            Invoke(nameof(ToggleAudio), _endPoint - _startPoint);
        }
    }
}