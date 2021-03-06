﻿using System;
using EloBuddy;
using EloBuddy.SDK.Events;

namespace LevelZero.Model.Interfaces
{
    public interface IChampion
    {
        void Init();
        void InitVariables();
        void InitMenu();
        void InitEvents();
        void OnCombo();
        void OnHarass();
        void OnLaneClear();
        void OnJungleClear();
        void OnLastHit();
        void OnFlee();
        void PermaActive();
        void OnUpdate(EventArgs args);
        void OnDraw(EventArgs args);
        void OnAfterAttack(AttackableUnit target, EventArgs args);
        void OnPossibleToInterrupt(Obj_AI_Base sender, Interrupter.InterruptableSpellEventArgs interruptableSpellEventArgs);
        void OnGapCloser(AIHeroClient sender, Gapcloser.GapcloserEventArgs e);
        void OnProcessSpell(Obj_AI_Base sender, GameObjectProcessSpellCastEventArgs args);
        void OnPlayerLevelUp(Obj_AI_Base sender, Obj_AI_BaseLevelUpEventArgs args);
        void GameObjectOnCreate(GameObject sender, EventArgs args);
        void GameObjectOnDelete(GameObject sender, EventArgs args);
    }
}
