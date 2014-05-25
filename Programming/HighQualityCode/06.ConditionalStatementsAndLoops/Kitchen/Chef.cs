// ********************************
// <copyright file="Chef.cs" company="Telerik Academy">
// Copyright (c) 2014 Telerik Academy. All rights reserved.
// </copyright>
//
// ********************************
namespace Kitchen
{
    /// <summary>
    /// Represents a chef.
    /// </summary>
    public class Chef
    {
        /// <summary>
        /// Keeps the actions that are performed while cooking.
        /// </summary>
        private CookingLog cookingLog = new CookingLog();

        /// <summary>
        /// Gets the contents of the cooking log.
        /// </summary>
        public string Log
        {
            get
            {
                return this.cookingLog.ToString();
            }
        }

        /// <summary>
        /// Describes the sequence of steps necessary to complete
        /// the soup-making process.
        /// </summary>
        public void MakeSoup()
        {
            Pot pot = this.GetPot();

            this.FillWithWater(pot);

            Potato potato = this.GetPotato();

            if (!potato.IsRotten)
            {
                if (!potato.IsPeeled)
                {
                    this.Peel(potato);
                }

                this.Wash(potato);
                this.Cut(potato);
            }
            else
            {
                this.MaybeNextTime(potato);
                return;
            }

            Carrot carrot = this.GetCarrot();

            if (!carrot.IsRotten)
            {
                if (!carrot.IsPeeled)
                {
                    this.Peel(carrot);
                }

                this.Wash(carrot);
                this.Cut(carrot);
            }
            else
            {
                this.MaybeNextTime(carrot);
                return;
            }

            this.PutIn(pot, potato);
            this.PutIn(pot, carrot);

            this.Boil(30);

            this.Success();
            return;
        }

        private Pot GetPot()
        {
            Pot pot = new Pot();
            this.cookingLog.Add("A developer makes soup.");
            this.cookingLog.Add(string.Format("Took a clean {0}.", pot));

            return pot;
        }

        private void FillWithWater(Utensil utensil)
        {
            string result = utensil.FillWithWater();
            this.cookingLog.Add(result);
        }

        private Carrot GetCarrot()
        {
            Carrot carrot = new Carrot();
            this.cookingLog.Add(string.Format("Found a {0}.", carrot));

            return carrot;
        }

        private Potato GetPotato()
        {
            Potato potato = new Potato();
            this.cookingLog.Add(string.Format("Found a {0}.", potato));

            return potato;
        }

        private void MaybeNextTime(Vegetable vegetable)
        {
            this.cookingLog.Add(string.Format("The {0} is rotten.", vegetable));
        }

        private void Peel(Vegetable vegetable)
        {
            vegetable.IsPeeled = true;
            this.cookingLog.Add(string.Format("Peeled the {0}.", vegetable));
        }

        private void Wash(Vegetable vegetable)
        {
            this.cookingLog.Add(string.Format("Washed the {0}.", vegetable));
        }

        private void Cut(Vegetable vegetable)
        {
            this.cookingLog.Add(string.Format("Cut the {0}.", vegetable));
        }

        private void PutIn(Utensil utensil, Vegetable vegetable)
        {
            string result = utensil.Add(vegetable);
            this.cookingLog.Add(result);
        }

        private void Boil(int minutes)
        {
            this.cookingLog.Add(string.Format("Wait for {0} minutes and then...", minutes));
        }

        private void Success()
        {
            this.cookingLog.Add("Bon appetit, mon ami!");
        }
    }
}