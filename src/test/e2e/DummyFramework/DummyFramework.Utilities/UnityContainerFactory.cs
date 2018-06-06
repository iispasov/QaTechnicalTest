using System.Linq;
using Unity;

namespace DummyFramework.Utilities
{
    public static class UnityContainerFactory
    {
        private static IUnityContainer _unityContainer;

        static UnityContainerFactory()
        {
            _unityContainer = new UnityContainer();
        }

        public static IUnityContainer GetCurrentContainer()
        {
            return _unityContainer;
        }

        public static bool IsContainerEmpty()
        {
            return !_unityContainer.Registrations.Any();
        }

        public static void ResetContainer()
        {
            _unityContainer = new UnityContainer();
        }
    }
}