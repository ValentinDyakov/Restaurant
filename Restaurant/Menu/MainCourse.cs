class MainCourse : Menu{
    public MainCourse(string name, int volume, double price){
        Name = name;
        Volume = volume;
        Price = price;
        Calories = Volume * 1.7;
    }
}