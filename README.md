# GLEntitySystem
GLEntitySystem consists of entities that could hold components. Components determine how the entity acts before and during runtime.
Currently, these entities are used to render meshes in an open gl context but more sophisticated components will be added.
## Create Entity
Entities are created with the entity class 
```
Entity entity = new Entity()
```
To add components, use the ```AddComponent()``` method.
```
entity.AddComponent<T>(new T())
```

Additionally, you can also get a specific component or get all the components from the entity.
```
entity.GetComponent<T>() //Gets the first component of the given type
entity.GetComponents() //Gets all the components of the entity
```

## Create Components
Components can be created by inheriting the	```IComponent``` interface.
```
class CustomComponent : IComponent
{
	public void OnStart(Entity entity) { }
	public void OnUpdate(Entity entity) { }
}
```
The IComponent requires you to implement the ```OnStart()``` and ```Onupdate()``` methods. 
```OnStart()```is executed as soon as the component is added.
```OnUpdate()``` is executed every frame.

The two methods are also passed with a reference of the parent entity. So you could modify it's behaviour.