﻿namespace StoreForCarParts
{
    using System.Collections.Generic;
    using System.Text;

    public class Shop
    {
        private string name;
        private List<Part> parts;

        public Shop(string name)
        {
            this.name = name;
            this.parts = new List<Part>();
        }

        public void AddPart(Part part)
        {
            this.parts.Add(part);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Shop: " + this.name + "\n");
            foreach (Part part in this.parts)
            {
                result.Append(part);
                result.AppendLine();
            }

            return result.ToString();
        }
    }
}