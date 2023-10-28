using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PalancaTrigger : MonoBehaviour
{
    [SerializeField] private UnityEvent OnPalancaTriggered;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            OnPalancaTriggered.Invoke();
        }
    }
}