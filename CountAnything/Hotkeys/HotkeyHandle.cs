namespace CountAnything.Hotkeys {
    class HotkeyHandle {
        public delegate void UnmapHandler();

        private readonly UnmapHandler _unmapHandler;

        private HotkeyHandle(UnmapHandler unmapHandler)
        {
            _unmapHandler = unmapHandler;
        }

        public void Unmap()
        {
            _unmapHandler();
        }

        public static HotkeyHandle Create(UnmapHandler unmapHandler)
        {
            return new HotkeyHandle(unmapHandler);
        }
    }
}
