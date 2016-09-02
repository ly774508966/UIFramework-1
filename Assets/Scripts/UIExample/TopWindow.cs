﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UIFramework;

public class TopWindow : Window
{
    public Button backBtn;
    public Button skillBtn;

    public TopWindow() : base(WindowType.Fixed, HideMode.HideNothing, "UIPrefabs/UITopWindow", false) { }

    public override void Init()
    {
        base.Init();

        backBtn = uiTransform.Find("BtnBack").GetComponent<Button>();
        skillBtn = uiTransform.Find("BtnSkill").GetComponent<Button>();

        backBtn.onClick.AddListener(() => { WindowManager.Instance.GoBack(); });
        skillBtn.onClick.AddListener(() => { WindowManager.Instance.LoadWindow<SkillWindow>(); });
    }

    public override void Show()
    {
        base.Show();
    }

    public override void Hide()
    {
        base.Hide();
    }

    public override void Destroy()
    {
        base.Destroy();
    }
}
