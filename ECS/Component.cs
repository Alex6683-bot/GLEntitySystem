namespace GLEntitySystem
{
    public abstract class Component
    {
        public Entity Entity { get; set; }
        public List<ComponentFlag> flags { get; } = new List<ComponentFlag>();
        public virtual void OnStart(Entity entity)
        {
            Entity = entity;
        }
        public virtual void OnUpdate(Entity entity)
        { }

    }
}
