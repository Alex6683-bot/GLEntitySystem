namespace GLEntitySystem
{
    public interface IComponent
    {
        public void OnStart(Entity entity);
        public void OnUpdate(Entity entity);

    }
}
