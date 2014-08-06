namespace Computers.HardwareComponents
{
    using System;

    using Contracts;

    // TODO: implement the Mediator pattern
    public class Motherboard : IMotherboard
    {
        /// <summary>
        /// Load values from the RAM
        /// </summary>
        /// <returns>loaded value</returns>
        public int LoadRamValue()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Save values to the RAM
        /// </summary>
        /// <param name="value">value to save</param>
        public void SaveRamValue(int value)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Draw on the video card
        /// </summary>
        /// <param name="data">data to draw</param>
        public void DrawOnVideoCard(string data)
        {
            throw new NotImplementedException();
        }
    }
}