namespace Hw1
{
    public interface ICity
    {
        Human[] Humans { get; }
        void AddHuman(Human human);
        Human[] SearchHumans(string search);
    }
}