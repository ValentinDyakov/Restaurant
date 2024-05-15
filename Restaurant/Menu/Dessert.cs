class Dessert : Menu{
    public Dessert(string name, int volume, double price){
        Name = name;
        Volume = volume;
        Price = price;
        Calories = Volume * 3;
    }
}