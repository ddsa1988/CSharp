namespace ShoeStore.Models;

public class ShoeCloset {
    private readonly List<Shoe> _shoes = [];

    public void AddShoe(Shoe shoe) {
        _shoes.Add(shoe);
    }

    public Shoe? RemoveShoeAt(int index) {
        if (index < 1 || index > _shoes.Count) return null;

        Shoe shoe = _shoes[index - 1];
        _shoes.RemoveAt(index - 1);

        return shoe;
    }

    public void PrintShoes() {
        if (_shoes.Count == 0) {
            Console.WriteLine("The shoe closet is empty.");
            return;
        }

        Console.WriteLine("The shoe closet contains:");

        for (int i = 0; i < _shoes.Count; i++) {
            Console.WriteLine($"Shoe #{i + 1}: {_shoes[i]}");
        }
    }
}