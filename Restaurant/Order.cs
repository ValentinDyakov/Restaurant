class Order{
    IList<string> order = new List<string>();
    public Order(IList<string> ordersList){
        this.order = ordersList;
    }

    public IList<string> Order_{get{return order;} set{order = value;}}
}