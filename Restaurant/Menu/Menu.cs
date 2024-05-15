

abstract class Menu{
    string name;
    public int volume;
    double price;
    double calories;

    public Menu(){

    }
    public Menu(string name,int volume, double price){
        this.name = name;
        this.volume = volume;
        this.price = price;
    }
    public string Name{ get{return name;} set{name = value;} }
    public int Volume{ get{return volume;} set{volume = value;} }
    public double Price{ get{return price;} set{price = value;} }
    public double Calories{ get{return calories;} set{calories = value;} }

    
}