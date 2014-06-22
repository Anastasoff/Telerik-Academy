namespace AcademyPopcorn
{
    using System.Collections.Generic;

    // 6. Implement a MeteoriteBall. It should inherit the Ball class and should leave a trail of TrailObject objects. 
    // Each trail objects should last for 3 "turns". Other than that, 
    // the Meteorite ball should behave the same way as the normal ball. 
    // You must NOT edit any existing .cs file.
    public class MeteoriteBall : Ball
    {
        public MeteoriteBall(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, speed)
        {
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            var produceObjects = new List<GameObject>();
            produceObjects.Add(new TrailObject(this.topLeft, new char[,] { { '*' } }, 3));
            return produceObjects;
        }
    }
    //// end - task 6.
}
