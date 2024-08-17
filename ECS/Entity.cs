using OpenTK.Mathematics;

namespace GLEntitySystem
{
    public class Entity
    {
        private List<IComponent> _components;
        public List<IComponent> components { get => _components; }

        //Origin
        public Vector3 position = new Vector3(0);
        public Vector3 scale = new Vector3(1);
        public Vector3 rotation = new Vector3(0);
        public Entity()
        {
            _components = new List<IComponent>();
        }

        public void Update()
        {
            foreach (var component in _components) component.OnUpdate(this);
        }

        /// <summary>
        /// Gets the first component of the given type from entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>Component deriving from IComponent interface. Returns null if not found</returns>
        public IComponent? GetComponent<T>() where T : IComponent
        {
            return _components.Where(x => x.GetType() == typeof(T)).FirstOrDefault();
        }

        /// <summary>
        /// Gets components of the given type from entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>List of components deriving of the give type. Returns null if not found</returns>
        public List<IComponent>? GetComponents<T>() where T : IComponent
        {
            return _components.Where(x => x.GetType() == typeof(T)).ToList();
        }

        /// <summary>
        /// Returns all the components in the entity
        /// </summary>
        /// <returns></returns>
        public List<IComponent>? GetComponents()
        {
            return _components;
        }

        /// <summary>
        /// Adds a component deriving from IComponent interface
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="component"></param>
        public void AddComponent<T>(T component) where T : IComponent
        {
            _components.Add(component);
            component.OnStart(this);
        }

    }
}
