using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAndScaleOnKeyPress : MonoBehaviour
{
    [Header("Rotation Settings")]
    [SerializeField] private float rotationAngle = 360f;
    [SerializeField] private float rotationDuration = 2f;
    [SerializeField] private Ease rotationEase = Ease.InOutBounce;

    [Header("Punch Scale Settings")]
    [SerializeField] private Vector3 punchScale = new Vector3(1.2f, 1.2f, 1.2f);
    [SerializeField] private float punchDuration = 1f;
    [SerializeField] private int punchVibrato = 10;
    [SerializeField] private float punchElasticity = 1f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log(
                $"<color=green>[ нопка 1]</color> - <color=yellow>ќб'Їкт повертаЇтьс€</color>"
            );
            RotateCube();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log(
                $"<color=blue>[ нопка 2]</color> - <color=magenta>ќб'Їкт виконуЇ Punch Scale</color>"
            );
            PunchScaleCube();
        }
    }

    private void RotateCube()
    {
        transform.DORotate(new Vector3(0, rotationAngle, 0), rotationDuration, RotateMode.LocalAxisAdd)
                .SetEase(rotationEase);
    }

    private void PunchScaleCube()
    {
        transform.DOPunchScale(punchScale, punchDuration, punchVibrato, punchElasticity);
    }
}