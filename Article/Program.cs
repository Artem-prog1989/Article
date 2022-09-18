class Article
{
    string name;
    string shop;
    int price;
    public string Name  
    {
        get { return name; } 
    }
    public string Shop
    {
        get { return shop; }
    }
    
    public int Price
    {
        get { return price; }
    }
    public Article(string name, string shop, int price)
    {
        this.name = name;
        this.shop = shop;
        this.price = price;
    }
}

class Store
{
    Article[] articles;
    public Store(Article[] article)
    {
        this.articles = article;
    }

    public Article this[int index]
    {
        
        get
        {
            if(index<articles.Length|| index > 0)
            {
                return articles[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
            
        }
        
       
    }
}
    class Program
    {
        public static void Main(string[] args)
        {
        Store store = new Store(new Article[] { new Article("телевизор", "Зодиак", 300), new Article("холодильник", "Норд", 500), new Article("шкаф", "мир мебели", 700) });
        Console.WriteLine(store[2].Name);
        }
    }
