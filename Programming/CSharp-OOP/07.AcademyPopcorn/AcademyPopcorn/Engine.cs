namespace AcademyPopcorn
{
    using System.Collections.Generic;

    public class Engine
    {
        private IRenderer renderer;
        private IUserInterface userInterface;
        private List<GameObject> allObjects;
        private List<MovingObject> movingObjects;
        private List<GameObject> staticObjects;
        private Racket playerRacket;

        // 2. The Engine class has a hard-coded sleep time. 
        // Make the sleep time a field in the Engine and implement a constructor, 
        // which takes it as an additional parameter.
        private int gameSpeed;

        public Engine(IRenderer renderer, IUserInterface userInterface)
            : this(renderer, userInterface, 100)
        {
        }

        public Engine(IRenderer renderer, IUserInterface userInterface, int gameSpeed)
        {
            this.renderer = renderer;
            this.userInterface = userInterface;
            this.gameSpeed = gameSpeed;
            this.allObjects = new List<GameObject>();
            this.movingObjects = new List<MovingObject>();
            this.staticObjects = new List<GameObject>();
        }

        //// end - task 2.

        public virtual void AddObject(GameObject obj)
        {
            if (obj is MovingObject)
            {
                this.AddMovingObject(obj as MovingObject);
            }
            else
            {
                if (obj is Racket)
                {
                    this.AddRacket(obj);
                }
                else
                {
                    this.AddStaticObject(obj);
                }
            }
        }

        public virtual void MovePlayerRacketLeft()
        {
            this.playerRacket.MoveLeft();
        }

        public virtual void MovePlayerRacketRight()
        {
            this.playerRacket.MoveRight();
        }

        public virtual void Run()
        {
            while (true)
            {
                this.renderer.RenderAll();

                System.Threading.Thread.Sleep(500);

                this.userInterface.ProcessInput();

                this.renderer.ClearQueue();

                foreach (var obj in this.allObjects)
                {
                    obj.Update();
                    this.renderer.EnqueueForRendering(obj);
                }

                CollisionDispatcher.HandleCollisions(this.movingObjects, this.staticObjects);

                List<GameObject> producedObjects = new List<GameObject>();

                foreach (var obj in this.allObjects)
                {
                    producedObjects.AddRange(obj.ProduceObjects());
                }

                this.allObjects.RemoveAll(obj => obj.IsDestroyed);
                this.movingObjects.RemoveAll(obj => obj.IsDestroyed);
                this.staticObjects.RemoveAll(obj => obj.IsDestroyed);

                foreach (var obj in producedObjects)
                {
                    this.AddObject(obj);
                }
            }
        }

        private void AddStaticObject(GameObject obj)
        {
            this.staticObjects.Add(obj);
            this.allObjects.Add(obj);
        }

        private void AddMovingObject(MovingObject obj)
        {
            this.movingObjects.Add(obj);
            this.allObjects.Add(obj);
        }

        private void AddRacket(GameObject obj)
        {
            // TODO: we should remove the previous racket from this.allObjects
            // 3. Search for a "TODO" in the Engine class, regarding the AddRacket method. 
            // Solve the problem mentioned there. There should always be only one Racket. 
            // Note: comment in TODO not completely correct
            this.playerRacket = obj as Racket;
            for (int i = 0; i < this.allObjects.Count; i++)
            {
                if (this.allObjects[i] is Racket)
                {
                    this.allObjects.RemoveAt(i);
                    i--;
                }
            }

            for (int i = 0; i < this.staticObjects.Count; i++)
            {
                if (this.staticObjects[i] is Racket)
                {
                    this.staticObjects.RemoveAt(i);
                    i--;
                }
            }

            //// end - task 3.

            this.AddStaticObject(obj);
        }
    }
}
