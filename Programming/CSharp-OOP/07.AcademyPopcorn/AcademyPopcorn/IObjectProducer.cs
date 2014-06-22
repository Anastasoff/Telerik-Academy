namespace AcademyPopcorn
{
    using System.Collections.Generic;

    public interface IObjectProducer
    {
        IEnumerable<GameObject> ProduceObjects();
    }
}
