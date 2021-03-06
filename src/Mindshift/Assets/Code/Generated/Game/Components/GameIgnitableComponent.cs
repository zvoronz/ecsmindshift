//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Assets.Code.Components.Ignitable ignitableComponent = new Assets.Code.Components.Ignitable();

    public bool isIgnitable {
        get { return HasComponent(GameComponentsLookup.Ignitable); }
        set {
            if (value != isIgnitable) {
                var index = GameComponentsLookup.Ignitable;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ignitableComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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

    static Entitas.IMatcher<GameEntity> _matcherIgnitable;

    public static Entitas.IMatcher<GameEntity> Ignitable {
        get {
            if (_matcherIgnitable == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Ignitable);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherIgnitable = matcher;
            }

            return _matcherIgnitable;
        }
    }
}
