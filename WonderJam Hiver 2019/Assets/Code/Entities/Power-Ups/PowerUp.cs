﻿using UnityEngine;
using UnityEngine.UI;

public abstract class PowerUp : ScriptableObject
{
	public Image m_icon;
	public SimpleAudioEvent m_pickupAudioEvent;

    public abstract void Use(Shooter p_shooter);
    public abstract void End(Shooter p_shooter);
}
