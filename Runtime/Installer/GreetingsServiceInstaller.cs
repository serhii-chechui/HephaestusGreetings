using Zenject;

namespace WTFGames.Hephaestus.GreetingsService
{
    public class GreetingsServiceInstaller : Installer<GreetingsServiceInstaller>
    {
        public override void InstallBindings()
        {
            #if UNITY_IOS
            Container.BindInterfacesTo<iOSGreetingsService>().AsSingle();
            #elif UNITY_ANDROID
            Container.BindInterfacesTo<AndroidGreetingsService>().AsSingle();
            #elif UNITY_EDITOR
            Container.BindInterfacesTo<GreetingsService>().AsSingle();
            #endif
        }
    }
}