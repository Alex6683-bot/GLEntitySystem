namespace GLEntitySystem
{
    public interface IComponent
    {
        public Entity Entity { get; set; }
        public bool enabled { get; set; }
        public void OnStart(Entity entity)
        { 
            Entity = entity;
            enabled = true;
        }
        public void OnUpdate(Entity entity)
        {
            if (!enabled) return;
        }

    }
}
