public class Ogrenci:IDondu{

    private string name;
    public int Id { get; set; }
    public string Name { get =>this.name;  set => this.name=value; }

    public void Oku()
    {
        throw new NotImplementedException();
    }
}