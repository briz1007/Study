namespace DIPDemo
{
    // WIthout DIP
    class Employee
    {
        public class BusinessLayerLogic
        {
            private readonly DataAccessLayer DAL;
            public BusinessLayerLogic()
            {
                DAL = new DataAccessLayer();
            }
            public void Save(Object details)
            {
                DAL.Save(details);
            }

        }
        public class DataAccessLayer
        {
            public void Save(Object details)
            {
                //
            }
        }
    }
    // With DIP
    class Program
    {
        public class BusinessLayerLogic
        {
            private readonly IRepositoryLayer DAL;
            public BusinessLayerLogic(IRepositoryLayer repositoryLayer)
            {
                DAL = repositoryLayer;
            }
            public void Save(Object details)
            {
                DAL.Save(details);
            }

        }
        public interface IRepositoryLayer
        {
            void Save(Object details);
        }
        public class DataAccessLayer : IRepositoryLayer
        {
            public void Save(Object details)
            {
                //
            }
        }
    }
}