class Soup : Menu{
    public Soup(string name, int volume, double price){
        Name = name;
        Volume = volume;
        Price = price;
        Calories = Volume * 1;
    }
}