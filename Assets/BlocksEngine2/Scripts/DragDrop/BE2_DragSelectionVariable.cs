﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BE2_DragSelectionVariable : MonoBehaviour, I_BE2_Drag
{
    BE2_DragDropManager _dragDropManager;
    RectTransform _rectTransform;
    BE2_UI_SelectionBlock _uiSelectionBlock;
    ScrollRect _scrollRect;

    // v2.1 - using BE2_Text to enable usage of Text or TMP components
    BE2_Text _text;

    Transform _transform;
    public Transform Transform => _transform ? _transform : transform;
    public Vector2 RayPoint => _rectTransform.position;
    public I_BE2_Block Block => null;
    public List<I_BE2_Block> ChildBlocks => null;

    void Awake()
    {
        _transform = transform;
        _rectTransform = GetComponent<RectTransform>();
        _uiSelectionBlock = GetComponent<BE2_UI_SelectionBlock>();
        _scrollRect = GetComponentInParent<ScrollRect>();
        _text = BE2_Text.GetBE2TextInChildren(transform);
    }

    void Start()
    {
        _dragDropManager = BE2_DragDropManager.instance;
        BE2_MainEventsManager.Instance.StartListening(BE2EventTypes.OnPointerUpEnd, EnableScroll);
    }

    void OnDisable()
    {
        BE2_MainEventsManager.Instance.StopListening(BE2EventTypes.OnPointerUpEnd, EnableScroll);
    }

    void EnableScroll()
    {
        _scrollRect.enabled = true;
    }

    //void Update()
    //{
    //
    //}

    public void OnPointerDown()
    {

    }

    public void OnRightPointerDownOrHold()
    {
        
    }

    public void OnDrag()
    {
        _scrollRect.StopMovement();
        _scrollRect.enabled = false;

        GameObject prefabBlock = Instantiate(_uiSelectionBlock.prefabBlock);
        prefabBlock.name = _uiSelectionBlock.prefabBlock.name;
        I_BE2_Block newBlock = prefabBlock.GetComponent<I_BE2_Block>();
        newBlock.Drag.Transform.SetParent(_dragDropManager.DraggedObjectsTransform, true);

        // v2.1 - using BE2_Text to enable usage of Text or TMP components
        BE2_Text newVariableText = BE2_Text.GetBE2Text(newBlock.Layout.SectionsArray[0].Header.ItemsArray[0].Transform);
        newVariableText.text = _text.text;
        newVariableText.GetComponent<BE2_BlockSectionHeader_VariableLabel>().UpdateValues();

        prefabBlock.transform.localScale = Vector3.one;
        prefabBlock.transform.position = transform.position;
        _dragDropManager.CurrentDrag = newBlock.Drag;

        newBlock.Drag.OnPointerDown();
        newBlock.Drag.OnDrag();
    }

    public void OnPointerUp()
    {

    }
}
