// Copyright (c) 2019 Justin Couch / JustInvoke
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PowerslideKartPhysics
{
    //Class for boost item
    public class BoostItem : Item
    {
        public float boostAmount = 50f;
        public float boostForce = 50f;

        //Award boost to kart upon activation
        public override void Activate(ItemCastProperties props)
        {
            base.Activate(props);
            if (props.castKart != null)
            {
                if (props.castKart.canBoost)
                {
                    props.castKart.AddBoost(boostAmount, boostForce);
                    props.castKart.boostStartEvent.Invoke();
                }
            }
        }
    }
}