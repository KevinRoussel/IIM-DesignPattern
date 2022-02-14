using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ChangeColor : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler
{
    [Header("Dependencies")]
    [SerializeField] MeshRenderer _renderer;
    [Header("Conf")]
    [SerializeField] Color _baseColor;
    [SerializeField] Color _overColor;
    [SerializeField] Color _clickColor;

    #region Editor
    void Reset()
    {
        _renderer = GetComponent<MeshRenderer>();
        _baseColor = Color.red;
        _overColor = Color.yellow;
        _clickColor = Color.green;
    }
    void OnValidate()
    {
        UseColor(_baseColor);
    }
    #endregion

    void UseColor(Color c) => _renderer.sharedMaterial.SetColor("_BaseColor", c);

    public void OnPointerClick(PointerEventData eventData)
    {
        UseColor(_clickColor);
    }

    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        UseColor(_overColor);
    }


    [ContextMenu("MaFonction")]
    void MaFonction()
    {
        foreach(Transform el in transform)
        {
            GameObject.Destroy(el.gameObject);
        }
    }
}
