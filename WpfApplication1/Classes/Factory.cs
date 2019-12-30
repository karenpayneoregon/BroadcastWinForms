namespace WpfApplication1.Classes
{
    public static class Factory
    {
        private static Broadcaster _broadcaster;

        public static Broadcaster Broadcaster()
        {
            return _broadcaster ?? ( _broadcaster = new Broadcaster() );
        }
    }

}
