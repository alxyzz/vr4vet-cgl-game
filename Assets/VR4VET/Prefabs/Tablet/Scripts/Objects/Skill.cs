﻿/* Copyright (C) 2020 IMTEL NTNU - All Rights Reserved
 * Developer: Abbas Jafari
 * Ask your questions by email: a85jafari@gmail.com
 */

using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Tablet
{
    /// <summary>
    /// ferdighet object
    /// </summary>
    public class Skill : MonoBehaviour
    {
        private int totalPoints;
        private int achievedPoints;
        private string skillName;
        private string skillDescription;

        //hvor mye til hver aktivitet har gitt denne ferdighet (aktivitet,poeng)
        private Dictionary<Aktivitet, int> ferdighetAktiviteter = new Dictionary<Aktivitet, int>();


        /// <summary>
        /// get the dictionary of all aktivitet that are testet by this ferdighet
        /// </summary>
        /// <returns></returns>
        public Dictionary<Aktivitet, int> GetFerdighetAktiviteter()
        {
            return ferdighetAktiviteter;
        }


        /// <summary>
        /// Add an aktivitet to this ferdighet
        /// </summary>
        /// <param name="aktivitet"></param>
        /// <param name="value"></param>
        public void AddToFerdighetAktiviteter(Aktivitet aktivitet, int value)
        {
            if (!ferdighetAktiviteter.Keys.Contains(aktivitet))
            {
                if (achievedPoints + value < totalPoints)
                {
                    ferdighetAktiviteter.Add(aktivitet, achievedPoints + value);
                }
                else
                {
                    ferdighetAktiviteter.Add(aktivitet, value);
                }
            }
        }


        /// <summary>
        /// Get the name of this ferdighet
        /// </summary>
        /// <returns></returns>
        public string GetFerdighetName()
        {
            return skillName;
        }


        /// <summary>
        /// Set the name of this ferdighet
        /// </summary>
        /// <param name="value"></param>
        public void SetFerdighetName(string value)
        {
            skillName = value;
        }

        /// <summary>
        /// Get the total poeng that this ferdighet has gotten by all activities
        /// </summary>
        /// <returns></returns>
        public int GetTotalPoeng()
        {
            return totalPoints;
        }


        /// <summary>
        /// set the total poeng that this ferdighet can achieved to
        /// </summary>
        /// <param name="value"></param>
        public void SetTotalPoeng(int value)
        {
            totalPoints = value;
        }


        /// <summary>
        /// Get the poeng that the player has gotten from this ferdighet
        /// </summary>
        /// <returns></returns>
        public int GetAchievedPoeng()
        {
            achievedPoints = 0;
            foreach (KeyValuePair<Aktivitet, int> aktivitet in ferdighetAktiviteter)
            {
                achievedPoints += aktivitet.Value;
            }
            return achievedPoints;
        }


        /// <summary>
        /// set the poeng to this ferdighet
        /// </summary>
        /// <param name="value"></param>
        public void SetAchievedPoeng(int value)
        {
            achievedPoints = value;
        }


        /// <summary>
        /// Change the description of this ferdighet. can be used for feedback
        /// </summary>
        /// <param name="value"></param>
        public void SetFerdighetBeskrivelse(string value)
        {
            skillDescription = value;
        }
        

        /// <summary>
        ///Get the ferdighet description 
        /// </summary>
        /// <returns></returns>
        public string GetFerdighetBeskrivelse()
        {
            return skillDescription;
        }


        /// <summary>
        /// Add more poneg to this ferdighet
        /// </summary>
        /// <param name="value"></param>
        public void AddAchievedPoeng(int value)
        {
            if (achievedPoints + value < totalPoints)
                achievedPoints += value;
            else
                achievedPoints = totalPoints;
        }

    }
}