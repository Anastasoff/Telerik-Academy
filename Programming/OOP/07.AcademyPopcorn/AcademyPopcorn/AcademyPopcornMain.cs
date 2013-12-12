namespace AcademyPopcorn
{
    public class AcademyPopcornMain
    {
        private const int WorldRows = 23;
        private const int WorldCols = 40;
        private const int RacketLength = 6;

        public static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;

            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock;

                if (i == 7)
                {
                    currBlock = new ExplodingBlock(new MatrixCoords(startRow, i));
                }
                else if (i == endCol - 3)
                {
                    currBlock = new GiftBlock(new MatrixCoords(startRow, i));
                }
                else
                {
                    currBlock = new Block(new MatrixCoords(startRow, i));
                }

                engine.AddObject(currBlock);
            }

            Ball theBall = new Ball(new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(-1, 1));
            engine.AddObject(theBall);

            // 7. Test the MeteoriteBall by replacing the normal ball in the AcademyPopcornMain.cs file.
            // MeteoriteBall meteoriteBall = new MeteoriteBall(new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(-1, 1));
            // engine.AddObject(meteoriteBall);
            //// end - task 7.

            // 9. Test the UnpassableBlock and the UnstoppableBall.
            // UnstoppableBall unstoppableBall = new UnstoppableBall(
            //    new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(-1, 1));
            // engine.AddObject(unstoppableBall);
            // for (int i = 2; i < WorldCols; i += 5)
            // {
            //    engine.AddObject(new UnpassableBlock(new MatrixCoords(4, i)));
            // }
            //// end - task 9.

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);
            engine.AddObject(theRacket);
        }

        public static void Main()
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            Engine gameEngine = new Engine(renderer, keyboard);

            // 1. The AcademyPopcorn class contains an IndestructibleBlock class. 
            // Use it to create side and ceiling walls to the game. 
            // You can ONLY edit the AcademyPopcornMain.cs file.
            for (int i = 2; i < WorldRows; i++)
            {
                gameEngine.AddObject(new IndestructibleBlock(new MatrixCoords(i, 0)));
                gameEngine.AddObject(new IndestructibleBlock(new MatrixCoords(i, WorldCols - 1)));
            }

            for (int i = 0; i < WorldCols; i++)
            {
                gameEngine.AddObject(new IndestructibleBlock(new MatrixCoords(2, i)));
            }
            //// end - task 1.

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            Initialize(gameEngine);

            gameEngine.Run();
        }
    }
}
