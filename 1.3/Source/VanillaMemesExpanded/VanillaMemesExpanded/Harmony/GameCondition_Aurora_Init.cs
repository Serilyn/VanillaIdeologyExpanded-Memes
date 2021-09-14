﻿using HarmonyLib;
using RimWorld;
using System.Reflection;
using Verse;
using UnityEngine;
using System.Collections.Generic;
using System;
using Verse.AI;



namespace VanillaMemesExpanded
{


    [HarmonyPatch(typeof(GameCondition_Aurora))]
    [HarmonyPatch("Init")]
    public static class VanillaMemesExpanded_GameCondition_Aurora_Init_Patch
    {
        [HarmonyPostfix]
        static void SendRandomMood()
        {


            foreach (Pawn pawn in PawnsFinder.AllMapsCaravansAndTravelingTransportPods_Alive_Colonists)
            {
                System.Random random = new System.Random();
                int randomMood = random.Next(0, 9);
                PawnCollectionClass.AddColonistAndRandomMood(pawn, randomMood);
                PawnCollectionClass.SetColonistAndRandomMood(pawn, randomMood);

            }



        }
    }








}
