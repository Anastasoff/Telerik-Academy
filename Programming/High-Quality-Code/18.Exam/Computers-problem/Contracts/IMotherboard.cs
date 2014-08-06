namespace Contracts
{
    public interface IMotherboard
    {
        /// <summary>
        /// Load values from the RAM
        /// </summary>
        /// <returns>loaded value</returns>
        int LoadRamValue();

        /// <summary>
        /// Save values to the RAM
        /// </summary>
        /// <param name="value">value to save</param>
        void SaveRamValue(int value);

        /// <summary>
        /// Draw on the video card
        /// </summary>
        /// <param name="data">data to draw</param>
        void DrawOnVideoCard(string data);
    }
}