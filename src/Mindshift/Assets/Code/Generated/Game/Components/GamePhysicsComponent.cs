//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity physicsEntity { get { return GetGroup(GameMatcher.Physics).GetSingleEntity(); } }
    public Assets.Code.Components.Physics physics { get { return physicsEntity.physics; } }
    public Assets.Code.Services.IPhysicsService Physics { get { return physics.Value; } }
    public bool hasPhysics { get { return physicsEntity != null; } }

    public GameEntity SetPhysics(Assets.Code.Services.IPhysicsService newValue) {
        if (hasPhysics) {
            throw new Entitas.EntitasException("Could not set Physics!\n" + this + " already has an entity with Assets.Code.Components.Physics!",
                "You should check if the context already has a physicsEntity before setting it or use context.ReplacePhysics().");
        }
        var entity = CreateEntity();
        entity.AddPhysics(newValue);
        return entity;
    }

    public void ReplacePhysics(Assets.Code.Services.IPhysicsService newValue) {
        var entity = physicsEntity;
        if (entity == null) {
            entity = SetPhysics(newValue);
        } else {
            entity.ReplacePhysics(newValue);
        }
    }

    public void RemovePhysics() {
        physicsEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Assets.Code.Components.Physics physics { get { return (Assets.Code.Components.Physics)GetComponent(GameComponentsLookup.Physics); } }
    public Assets.Code.Services.IPhysicsService Physics { get { return physics.Value; } }
    public bool hasPhysics { get { return HasComponent(GameComponentsLookup.Physics); } }

    public GameEntity AddPhysics(Assets.Code.Services.IPhysicsService newValue) {
        var index = GameComponentsLookup.Physics;
        var component = (Assets.Code.Components.Physics)CreateComponent(index, typeof(Assets.Code.Components.Physics));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplacePhysics(Assets.Code.Services.IPhysicsService newValue) {
        var index = GameComponentsLookup.Physics;
        var component = (Assets.Code.Components.Physics)CreateComponent(index, typeof(Assets.Code.Components.Physics));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemovePhysics() {
        RemoveComponent(GameComponentsLookup.Physics);
        return this;
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherPhysics;

    public static Entitas.IMatcher<GameEntity> Physics {
        get {
            if (_matcherPhysics == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Physics);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPhysics = matcher;
            }

            return _matcherPhysics;
        }
    }
}
