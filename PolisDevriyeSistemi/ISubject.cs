namespace PolisDevriyeSistemi
{
    public interface ISubject
    {
        void ObserverEkle(IObserver polis);
        void HaberVer();
    }
}