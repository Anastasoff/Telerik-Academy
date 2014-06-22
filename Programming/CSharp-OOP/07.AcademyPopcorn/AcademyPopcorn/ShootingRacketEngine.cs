namespace AcademyPopcorn
{
    // 4. Inherit the Engine class. Create a method ShootPlayerRacket. Leave it empty for now.
    public class ShootingRacketEngine : Engine
    {
        public ShootingRacketEngine(IRenderer renderer, IUserInterface userInterface, int gameSpeed)
            : base(renderer, userInterface, gameSpeed)
        {
        }

        public void ShootPlayerRacket()
        {
        }
    }
    //// end - task 4.
}
