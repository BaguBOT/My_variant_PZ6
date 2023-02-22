namespace studentApp
{
    internal class garde {
        private string _garde;

    
        public string Garde {
            get => _garde;
            private set => _garde = value;
        }

        public garde( string name) {

            _garde = name;
        }
    }
}
