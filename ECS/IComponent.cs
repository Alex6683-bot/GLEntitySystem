namespace GLEntitySystem
{
    public interface IComponent
    {
        public Entity Entity { get; set; }
        public void OnStart(Entity entity)
        { 
            Entity = entity;
        }
        public void OnUpdate(Entity entity);

    }
}
