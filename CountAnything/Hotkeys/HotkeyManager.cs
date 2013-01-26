using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace CountAnything.Hotkeys {
    class HotkeyManager {
        public delegate void HotkeyHandler();

        public TimeSpan DoubleTapPrevention { get; set; }

        private readonly Agent _agent;
        private int _idCounter;

        public HotkeyManager()
        {
            _agent = new Agent();
            _agent.HotkeyTriggered += AgentOnHotkeyTriggered;
        }

        public HotkeyHandle Map(Hotkey hotkey, HotkeyHandler action)
        {
            var mapping = new HotkeyMapping {
                Hotkey = hotkey,
                Action = action,
                Id = Interlocked.Increment(ref _idCounter)
            };

            _agent.AddMapping(mapping);

            return HotkeyHandle.Create(() => _agent.RemoveMappingByHotkey(hotkey));
        }

        private void AgentOnHotkeyTriggered(object sender, HotkeyEventArgs e)
        {
            if(e.Mapping.LastPress + DoubleTapPrevention < DateTime.Now) {
                e.Mapping.LastPress = DateTime.Now;
                e.Mapping.Action();
            }
        }

        private class HotkeyMapping {
            public Hotkey Hotkey;
            public HotkeyHandler Action;
            public int Id;
            public bool Registered;
            public DateTime LastPress;
        }

        private class Agent : Form {
            private readonly List<HotkeyMapping> _mappings;
            private bool _hasHandle;

            public event EventHandler<HotkeyEventArgs> HotkeyTriggered;

            public Agent()
            {
                _mappings = new List<HotkeyMapping>();
            }

            public void AddMapping(HotkeyMapping mapping)
            {
                _mappings.Add(mapping);
                if(_hasHandle) {
                    RegisterMapping(mapping);
                } else {
                    CreateHandle();
                }
            }

            public void RemoveMappingByHotkey(Hotkey hotkey)
            {
                for(var i = 0; i < _mappings.Count; i++) {
                    if(_mappings[i].Hotkey == hotkey) {
                        UnregisterMapping(_mappings[i]);
                        _mappings.RemoveAt(i);
                        break;
                    }
                }
            }

            protected override void OnHandleCreated(EventArgs e)
            {
                base.OnHandleCreated(e);
                foreach(var mapping in _mappings) {
                    RegisterMapping(mapping);
                }
                _hasHandle = true;
            }

            protected override void OnHandleDestroyed(EventArgs e)
            {
                base.OnHandleDestroyed(e);
                foreach(var mapping in _mappings) {
                    UnregisterMapping(mapping);
                }
                _hasHandle = false;
            }

            protected override void WndProc(ref Message m)
            {
                base.WndProc(ref m);

                if(m.Msg == 0x0312) {
                    for(var i = 0; i < _mappings.Count; i++) {
                        if(_mappings[i].Id == (int) m.WParam) {
                            OnHotkeyTriggered(new HotkeyEventArgs(_mappings[i]));
                        }
                    }
                }
            }

            private void RegisterMapping(HotkeyMapping mapping)
            {
                if(mapping.Registered) return;
                HotkeyApi.Register(this, mapping.Id, mapping.Hotkey);
                mapping.Registered = true;
            }

            private void UnregisterMapping(HotkeyMapping mapping)
            {
                if(!mapping.Registered) return;
                HotkeyApi.Unregister(this, mapping.Id);
                mapping.Registered = false;
            }

            private void OnHotkeyTriggered(HotkeyEventArgs e)
            {
                var handler = HotkeyTriggered;
                if(handler != null) handler(this, e);
            }
        }

        private class HotkeyEventArgs : EventArgs {
            public HotkeyMapping Mapping { get; private set; }

            public HotkeyEventArgs(HotkeyMapping mapping)
            {
                Mapping = mapping;
            }
        }
    }
}
