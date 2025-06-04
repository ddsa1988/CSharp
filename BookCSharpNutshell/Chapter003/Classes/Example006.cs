namespace Chapter003.Classes;

public static class Example006 {
    public static void Run() {
        // Properties look like fields from the outside, but internally they contain logic, like methods do.
    }

    private class Stock {
        private decimal _currentPrice; // Private field
        private decimal _sharedOwned;

        public decimal CurrentPrice {
            // Public property
            get => _currentPrice;
            set => _currentPrice = value;
        }

        public decimal SharedOwned {
            get => _sharedOwned;
            set => _sharedOwned = value;
        }

        // public decimal Worth {
        //     get => _currentPrice * _sharedOwned; // Ready-only property
        // }

        public decimal Worth => CurrentPrice * SharedOwned;
    }
}